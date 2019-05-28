#if UNITY_EDITOR

using System;
using System.IO;
using System.Collections.Generic;

using MIU;
using UnityEngine;
using UnityEngine.Profiling;

using UnityEditor;
using System.IO.Compression;

public class LevelSerializer
{
    ProxyMeshManager meshManager = new ProxyMeshManager();

    static float[] stagingFloats = new float[1];
    static Vector3[] stagingVector3 = new Vector3[1];
    static Vector2[] stagingVector2 = new Vector2[1];

    public static string failCause = "";

    MapComponents mapComp;

    public static string GetCurrentSceneLevelId()
    {
        return UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
    }

    void OptimizeLevelGeometry(GameObject go)
    {
        var mfsFound = new List<MeshFilter>();
        go.GetComponentsInChildren<MeshFilter>(mfsFound);

        foreach (var mf in mfsFound)
        {
            // Only combine statically batched geometry.
            bool isStaticBatch = GameObjectUtility.AreStaticEditorFlagsSet(mf.gameObject, StaticEditorFlags.BatchingStatic);
            if (isStaticBatch == false)
                continue;

            if (mf.gameObject.activeInHierarchy == false || mf.gameObject.GetComponent<IgnoreObject>() != null)
                continue;

            ProxyMeshInfo.MeshTypes type = 0;

            var collider = mf.GetComponent<Collider>();
            if(collider != null && collider.enabled)
                type |= ProxyMeshInfo.MeshTypes.IsCollider;

            var renderer = mf.GetComponent<Renderer>();
            if(renderer != null && renderer.enabled)
                type |= ProxyMeshInfo.MeshTypes.IsVisual;

            if(type == 0)
                continue;

            meshManager.AddMeshToProxy(mf, type);
        }

    }

    bool IsGameObjectPrunable(GameObject go)
    {
        // If it's not enabled we can bail immediately.
        if(go.activeInHierarchy == false || go.GetComponent<IgnoreObject>() != null)
            return true;

        // Process all our children to see if they are themselves
        // prunable.
        foreach (Transform t in go.transform)
        {
            if(IsGameObjectPrunable(t.gameObject))
                continue;

            return false;            
        }

        // Don't prune stuff with children.
        // TODO: is this check redundant?
        if (go.transform.childCount != 0)
            return false;

        // Don't prune stuff with components.
        var coms = go.GetComponents<Component>();
        if (coms.Length > 0)
            return false;

        return true;
    }

    void HandleSun(GameObject r, LevelScene scene)
    {
        var lights = r.GetComponentsInChildren<Light>();
        foreach(var l in lights)
        {
            if(l.type != LightType.Directional)
                continue;

            scene.sunDirection = l.transform.forward;
        }
    }

    void HandlePreviewCamera(GameObject r, LevelScene scene)
    {
        var camera = r.GetComponentInChildren<Camera>();
        if(camera != null)
        {
            scene.previewPosition = camera.transform.position;
            scene.previewOrientation = camera.transform.rotation;
        }
    }

    public void Serialize(ref ByteStream levelBits, GameObject excludeRoot = null)
    {
        // Make sure that we have our map components.
        EnsureMapComponentsLoaded();

        meshManager.Clear();

        var scene = new LevelScene();
        scene.root.name = scene.name = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
        int id = 0;
        int.TryParse(RenderSettings.skybox.name, out id);
        if (id < 5)
            id = 11;
        scene.skyboxId = id; 
        
        // Grab a copy of the world...
        var rootObjects = UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetRootGameObjects();
        foreach (GameObject r in rootObjects)
        {
            if (r == excludeRoot)
                continue;

            OptimizeLevelGeometry(r);

            HandleSun(r, scene);
            HandlePreviewCamera(r, scene);

            var item = SerializeGameObject(r, true);
            if (item != null)
                scene.root.children.Add(item);
        }

        meshManager.FinalizeProxies();

        // Now generate some static GOs and add to the scene. We generate 
        // separate GOs for renderable, collidable or both geometry.
        foreach (var pm in meshManager.Proxies)
        {
            var staticGo = new GameObject();
                
            staticGo.name = "StaticMesh_" + (pm.material != null ? pm.material.name : "Invisible");

            var mf = staticGo.AddComponent<MeshFilter>();
            mf.sharedMesh = pm.mesh;

            if((pm.type & ProxyMeshInfo.MeshTypes.IsVisual) != 0)
            {
                var mr = staticGo.AddComponent<MeshRenderer>();
                mr.material = pm.material;

                // Need to actually set these values to get lightmapping...
                mr.lightmapIndex = 0;
                mr.lightmapScaleOffset = new Vector4(1, 1, 0, 0);

                staticGo.name += "_R";
            }

            if ((pm.type & ProxyMeshInfo.MeshTypes.IsCollider) != 0)
            {
                staticGo.AddComponent<MeshCollider>();
 
                staticGo.name += "_MC";
            }

            var levelRoot = SerializeGameObject(staticGo);
            if (levelRoot != null)
                scene.root.children.Add(levelRoot);

            levelRoot.mesh.Flags |= LevelMesh.MeshFlags.IsStatic;

            GameObject.DestroyImmediate(staticGo);
        }

        // Do final propagation of max vertex counts.
        foreach (var c in scene.root.children)
        {
            if (c.LargestChildVertexCount > scene.root.LargestChildVertexCount)
                scene.root.LargestChildVertexCount = c.LargestChildVertexCount;
        }

        // Actually write to stream.
        Profiler.BeginSample("Serialize");

        var sh = new SerializerHelper();
        sh.Stream = new ByteStream();

        // Write header info - Marble it Up Level v5
        // v1 - initial format
        // v2 - added lightmaps
        // v3 - added level timing
        // v4 - added map hash
        // v5 - added map author
        sh.Stream.WriteByte((byte)'m');
        sh.Stream.WriteByte((byte)'u');
        sh.Stream.WriteByte((byte)'l');
        sh.Stream.WriteByte((byte)'6');

        if (GameObject.Find("StartPad") == null)
        {
            sh.Stream.WriteByte((byte)'M'); // Multiplayer
            sh.Stream.WriteByte((byte)'1'); // TODO - Encode MP Mode support
        }
        else
        {
            sh.Stream.WriteByte((byte)'S'); // Singleplayer
            sh.Stream.WriteByte((byte)'0'); // Unused MP Mode support
        }

        float silver = 45, gold = 20, diamond = 15;
        LevelTiming lt = GameObject.FindObjectOfType<LevelTiming>();
        if (lt != null)
        {
            silver = (float)(Math.Truncate(100 * lt.SilverTime) / 100f);
            gold = (float)(Math.Truncate(100 * lt.GoldTime) / 100f);
            diamond = (float)(Math.Truncate(100 * lt.DiamondTime) / 100f);
        }
        sh.Stream.WriteSingle(silver);
        sh.Stream.WriteSingle(gold);
        sh.Stream.WriteSingle(diamond);

        string author = "";
        if (lt != null)
            author = lt.Author;
        sh.Stream.WriteString(author);

        PlayModifiers phym = GameObject.FindObjectOfType<PlayModifiers>();
        string physParams = "";
        if (phym != null)
            physParams = phym.ToJSON();
        sh.Stream.WriteString(physParams);

        var hashStream = new SerializerHelper();
        hashStream.Write(scene);
        string hash = "000-" + UnityEngine.Random.Range(0, int.MaxValue);
        using (System.Security.Cryptography.SHA1CryptoServiceProvider sha1 = new System.Security.Cryptography.SHA1CryptoServiceProvider())
        {
            hash = Convert.ToBase64String(sha1.ComputeHash(hashStream.Stream.Buffer));
        }
        sh.Stream.WriteString(hash);

        // And write the scene.
        sh.Write(scene);

        // Also, write the lightmaps.
        SerializeLightmaps(ref sh);

        levelBits = sh.Stream;

        // If you want to enable compression of level files, this is
        // where to do it.
        //levelBits.Buffer = SerializerHelper.Compress(levelBits.Buffer);

        levelSize = levelBits.Position / 1024;
        Debug.Log("Serialized level, length = " + levelSize + "kb");
        
        Profiler.EndSample();
    }

    public static int levelSize;

    void SerializeLightmaps(ref SerializerHelper sh)
    {
        Texture2D color = null, dir = null, mask = null;

        if(LightmapSettings.lightmaps.Length > 0)
        {
            var lms = LightmapSettings.lightmaps[0];

            color= lms.lightmapColor;
            dir = lms.lightmapDir;
            mask = lms.shadowMask;
        }

        if (color != null && color.format != TextureFormat.DXT5Crunched)
        {
            failCause = "Lightmap Color Texture not DTX5 Crunched - Check requirements here: https://github.com/MarbleItUp/MIULevelCreationKit/blob/master/README.md#lightmaps";
            Debug.Log("Color Format: " + color.format);
            Selection.activeObject = color;
        }
        /*
        if (dir != null && !ValidFormat(dir.format))
        {
            failCause = "Lightmap Directional Texture not Compressed, please set <b>Texture Type - Default</b>, <b>Compression - Normal</b>, and turn on <b>Use Crunch Compression</b> to reduce file size";
            Selection.activeObject = dir;
        }
        */
        if (mask != null && !(mask.format == TextureFormat.DXT1 || mask.format == TextureFormat.DXT1Crunched))
        {
            failCause = "Lightmap Shadow Texture not DTX1 Crunched - Check requirements here: https://github.com/MarbleItUp/MIULevelCreationKit/blob/master/README.md#lightmaps";
            Debug.Log("Shadow Format: " + mask.format);
            Selection.activeObject = mask;
        }


        SerializeTexture(ref sh, color);
        SerializeTexture(ref sh, new Texture2D(2,2));
        SerializeTexture(ref sh, mask);
    }

    bool ValidFormat(TextureFormat format)
    {
        return true;// format == TextureFormat.DXT1Crunched || format == TextureFormat.BC6H || format == TextureFormat.DXT5Crunched;
    }

    void SerializeTexture(ref SerializerHelper sh, Texture2D tex)
    {
        // One byte flag indicating presence/absence.
        sh.Stream.WriteByte((tex == null) ? (byte)0 : (byte)1);
        if (tex == null)
            return;

        sh.Stream.WriteUInt16((ushort)tex.height);
        sh.Stream.WriteUInt16((ushort)tex.width);
        sh.Stream.WriteInt32((int)tex.format);

        var bits = tex.GetRawTextureData();
        sh.Stream.WriteBytes(bits, 0, bits.Length);        
    }

    LevelObject SerializeGameObject(GameObject go, bool rejectStatic = true)
    {
        var lo = new LevelObject();
        lo.name = MapComponents.FixName(go.name);
        go.name = lo.name;
        SerializeTransform(go, lo);

        SerializeTutorial(go, lo);
        SerializeBoxCollider(go, lo);
        SerializeMisc(go, lo);
        SerializeMover(go, lo);

        if (SerializePrefab(go, lo))
            return lo;

        SerializeMesh(go, lo, rejectStatic);

        bool skipChildren;
        bool doKeep = SerializeKnownComponents(go, lo, out skipChildren);

        lo.LargestChildVertexCount = lo.mesh != null ? lo.mesh.vertexCount : 0;

        for (var i = 0; i < go.transform.childCount; i++)
        {
            var child = go.transform.GetChild(i);

            if (skipChildren)
                continue;

            if (child.gameObject.activeInHierarchy == false)
                continue;
            
            if(IsGameObjectPrunable(child.gameObject))
                continue;

            var result = SerializeGameObject(go.transform.GetChild(i).gameObject);
            if (result == null)
                continue;

            lo.children.Add(result);
            lo.LargestChildVertexCount = Mathf.Max(lo.LargestChildVertexCount, lo.LargestChildVertexCount);
        }

        // Bail if we are empty and have no children.
        if (lo.children.Count == 0
            && lo.mesh.vertexCount == 0
            && (lo.prefabItem == null || lo.prefabItem == "")
            && !doKeep)
            return null;

        return lo;
    }

    bool SerializeKnownComponents(GameObject go, LevelObject lo, out bool skipChildren)
    {
        bool doKeep = false;
        skipChildren = false;

        /*
        var sdo = go.GetComponent<SpawnDriftingObjects>();
        if(sdo != null)
        {
            var sh = new SerializerHelper();
            sh.Stream = new ByteStream();
            sh.Write(sdo);

            var sb = new SimpleBuffer();
            sb.Stream = new MemoryStream(sh.Stream.Buffer, 0, sh.Stream.Position, true, true);

            lo.properties[LevelObject.SPAWN_DRIFTING_OBJECTS] = sb;
            lo.properties[LevelObject.SPAWN_DRIFTING_OBJECTS_TEMPLATE] = GetPrefabID(go.name, sdo.ObjectToSpawn);

            skipChildren = true;
            doKeep = true;
        }
        */

        var mta = go.GetComponent<MeshTunnelAnimator>();
        if(mta != null)
        {
            var sh = new SerializerHelper();
            sh.Stream = new ByteStream();
            sh.Write(mta);

            var sb = new SimpleBuffer();
            sb.Stream = new MemoryStream(sh.Stream.Buffer, 0, sh.Stream.Position, true, true);
            lo.properties[LevelObject.MESH_TUNNEL_ANIMATOR] = sb;

            if (mta.OverrideMaterial != null)
                lo.properties[LevelObject.MESH_TUNNEL_ANIMATOR_MATERIAL] = mapComp.ResolveMaterialToId(mta.OverrideMaterial);

            lo.properties[LevelObject.MESH_TUNNEL_ANIMATOR_DISPLAYMESH] = GetPrefabID(mta.DisplayMesh.name, mta.DisplayMesh);

            doKeep = true;
        }      

        var ps = go.GetComponent<ParticleSystem>();
        if(ps != null)
        {
            var sh = new SerializerHelper();
            sh.Stream = new ByteStream();
            sh.Write(ps);

            var sb = new SimpleBuffer();
            sb.Stream = new MemoryStream(sh.Stream.Buffer, 0, sh.Stream.Position, true, true);
            lo.properties[LevelObject.PARTICLE_SYSTEM] = sb;

            var psr = go.GetComponent<ParticleSystemRenderer>();
            lo.properties[LevelObject.PARTICLE_SYSTEM_MATERIAL] = mapComp.ResolveMaterialToId(psr.sharedMaterial);
            
            doKeep = true;
        }

        return doKeep;
    }

    void SerializeBoxCollider(GameObject go, LevelObject lo)
    {
        var box = go.GetComponent<BoxCollider>();
        if(box == null)
            return;
        
        lo.properties[LevelObject.BOX_COLLIDER] = true;
        lo.properties[LevelObject.BOX_COLLIDER_ISTRIGGER] = box.isTrigger;
        lo.SetVector3(LevelObject.BOX_COLLIDER_CENTER, box.center);
        lo.SetVector3(LevelObject.BOX_COLLIDER_SIZE, box.size);
    }

    void SerializeTutorial(GameObject go, LevelObject lo)
    {
        var tm = go.GetComponent<TutorialMessage>();
        if(tm == null)
            return;

        lo.properties[LevelObject.TUTORIAL] = true;
        lo.properties[LevelObject.TUTORIAL_GRAPHIC] = mapComp.ResolveSpriteToID(tm.graphic);
        lo.properties[LevelObject.TUTORIAL_MESSAGE] = tm.message;
        lo.properties[LevelObject.TUTORIAL_SHOWONCE] = tm.ShowOnce;
    }

    void SerializeMover(GameObject go, LevelObject lo)
    {
        var ev = go.GetComponent<ElevatorMover>();
        if(ev == null)
            return;

        if (go.GetComponentsInChildren<ElevatorMover>().Length > 1)
        {
            failCause = "Moving Platforms cannot be nested: " + go.name;
            Selection.activeGameObject = go.GetComponentsInChildren<ElevatorMover>()[1].gameObject;
            return;
        }
        if (go.GetComponent<MeshCollider>() == null)
        {
            failCause = "Moving Platforms must have a Mesh Collider component: " + go.name;
            Selection.activeGameObject = go;
            return;
        }
        
        var p = lo.properties;
        p[LevelObject.MOVER] = true;
        p[LevelObject.MOVER_MODE] = (int)ev.mode;
        p[LevelObject.MOVER_COLLAPSETRIGGERED] = ev.WaitForTouched;
        p[LevelObject.MOVER_STARTOFFSETTIME] = ev.StartOffsetTime;
        lo.SetVector3(LevelObject.MOVER_DELTA, ev.delta);
        lo.SetVector3(LevelObject.MOVER_DELTAROTATION, ev.deltaRotation);
        p[LevelObject.MOVER_PAUSETIME] = ev.pauseTime;
        p[LevelObject.MOVER_MOVETIME] = ev.moveTime;
        p[LevelObject.MOVER_MOVEFIRST] = ev.moveFirst;
        p[LevelObject.MOVER_SPLINESPEED] = ev.splineSpeed;
        p[LevelObject.MOVER_KEEPORIENTATION] = ev.KeepOrientation;

        p[LevelObject.MOVER_ENABLEBOB] = ev.EnableBob;
        if (ev.EnableBob)
        {
            p[LevelObject.MOVER_BOBOFFSET] = ev.BobOffset;
            p[LevelObject.MOVER_BOBPERIOD] = ev.BobPeriod;
            lo.SetVector3(LevelObject.MOVER_BOBVECTOR, ev.BobVector);
        }
        // Also the spline.
        if(ev.mode == ElevatorMover.Mode.Spline)
        {
            var splineGo = ev.splineGo;
            
            p[LevelObject.SPLINE] = true;
            p[LevelObject.SPLINE_COUNT] = splineGo.transform.childCount;
            for(var i=0; i<splineGo.transform.childCount; i++)
                lo.SetVector3(LevelObject.SPLINE_POSITION + i, splineGo.transform.GetChild(i).transform.position);
        }
    }

    void SerializeMisc(GameObject go, LevelObject lo)
    {
        if(go.name == "CheckPoint")
            lo.properties[LevelObject.CHECKPOINT] = true;
    }

    void SerializeTransform(GameObject go, LevelObject lo)
    {
        var xfrm = go.transform;
        lo.position = xfrm.position;
        lo.rotation = xfrm.rotation;
        lo.scale = xfrm.localScale;
    }

    // Bake set is the set of components are OK to bake out as geometry into
    // the FBX file. If we encounter components other than this then we will
    // (most likely) store a reference to a prefab or do other special handling.
    // TODO: The below lists of components can probably get cleaned up.
    bool IsBakeSetComponent(Component c)
    {
        return c is MeshFilter
        || c is Transform
        || c is MeshRenderer
        || c is BoxCollider
        || c is MeshCollider
        || c is Light
        || c is ParticleSystem
        || c == null;
    }

    bool CheckOnlySerializableComponents(Component[] cList)
    {
        foreach(var c in cList)
        {
            bool isOk = c is ParticleSystem 
                || c is Transform 
                || c is ParticleSystemRenderer;

            if(!isOk)
                return false;
        }

        return true;
    }

    // True if we only find "OK" components on this and its children. If so,
    // we can simply bake it out as mesh data.
    //
    // @see IsBakeSetComponent
    bool IsSafeToBake(GameObject checkObj)
    {
        if (checkObj.transform.childCount == 0 && checkObj.GetComponents<Component>().Length == 1) //Object is just a prefab ID
            return false;

        var les = checkObj.GetComponent<LevelExportSettings>();
        if(les != null && les.KeepPrefab)
            return false;

        var list = checkObj.GetComponentsInChildren<Component>();

        // Special case for only MTA/PS.
        if(CheckOnlySerializableComponents(list))
            return true;

        if (checkObj.isStatic == false)
            return false;

        foreach (var c in list)
        {
            if (!IsBakeSetComponent(c))
                return false;
        }

        if (checkObj.GetComponentsInChildren<MeshRenderer>().Length == 0)
            return false;

        return true;
    }

    string GetPrefabID(string name, GameObject prefabRef)
    {
        // name included for debugging use even though not hooked up here.
        return mapComp.ResolveNameToPrefabID(name);
    }

    // Serialize prefab state; return true if we did it because we can skip
    // the rest of normal processing in that case.
    bool SerializePrefab(GameObject go, LevelObject lo)
    {
        if (IsSafeToBake(go))
        {
            return false;
        }

        // If it only has one component which is a light, we can bail - it's the
        // sun which is extracted in another way.
        if(go.GetComponents<Component>().Length == 2 && go.GetComponent<Light>() != null)
        {
            return false;
        }

        if (MapComponents.FixName(go.name) == "CheckPoint" || MapComponents.FixName(go.name) == "LevelBounds" || go.GetComponent<TutorialMessage>() != null)
        {
            lo.prefabItem = GetPrefabID(MapComponents.FixName(go.name), null);
            return true;
        }

        int validChildren = 0;
        for(int i=0; i<go.transform.childCount; i++)
        {
            if (go.transform.GetChild(i).GetComponent<IgnoreObject>() == null)
                validChildren++;
        }

        if (validChildren == 0 && go.GetComponents<Component>().Length < 2)
        {
            lo.prefabItem = GetPrefabID(go.name, null);
            return true;
        }
        return false;
    }

    void SerializeMesh(GameObject go, LevelObject lo, bool rejectStatic = true)
    {
        MeshFilter mf = go.GetComponent<MeshFilter>();
        MeshRenderer mr = go.GetComponent<MeshRenderer>();

        bool isBatchStatic = GameObjectUtility.AreStaticEditorFlagsSet(go, StaticEditorFlags.BatchingStatic);
        bool isLightmapStatic = GameObjectUtility.AreStaticEditorFlagsSet(go, StaticEditorFlags.LightmapStatic);

        bool shouldBailDueToRejectingStatics = rejectStatic && isBatchStatic;

        if (mf == null || mf.sharedMesh == null || shouldBailDueToRejectingStatics)
        {
            lo.mesh = new LevelMesh();
            return;
        }

        var m = mf.sharedMesh;
        var lm = new LevelMesh();

        var mNormals = m.normals;
        var mUV1 = m.uv;
        var mUV2 = m.uv2;
        var mTangent = m.tangents;

        bool hasNormal = mNormals != null && mNormals.Length > 0;
        bool hasUV1 = mUV1 != null && mUV1.Length > 0;
        bool hasUV2 = mUV2 != null && mUV2.Length > 0;
        bool hasTangent = mTangent != null && mTangent.Length > 0;

        if (hasNormal)
            lm.Flags |= LevelMesh.MeshFlags.Normal;

        if (hasUV1)
            lm.Flags |= LevelMesh.MeshFlags.UV1;

        if (hasUV2)
            lm.Flags |= LevelMesh.MeshFlags.UV2;

        if (hasTangent)
            lm.Flags |= LevelMesh.MeshFlags.Tangent;

        Profiler.BeginSample("Write Verts");

        // TODO: We should reuse the stuff above.
        // Vertex order is: pos, norm, uv0, [uv1]
        var uv1 = new List<Vector2>();
        var uv2 = new List<Vector2>();
        var tangent = new List<Vector4>();

        if (hasUV1)
            m.GetUVs(0, uv1);
        if (hasUV2)
            m.GetUVs(1, uv2);
        if (hasTangent)
            m.GetTangents(tangent);

        Profiler.BeginSample("Copy Verts");

        var vertByteSize =
                3 * 4 + // Position
                (hasNormal ? 3 * 4 : 0) + // Normal
                (hasUV1 ? 2 * 4 : 0) + // UV1
                (hasUV2 ? 2 * 4 : 0) + // UV2
                (hasTangent ? 4 * 4 : 0) // Tangent
                ;

        var bytes = new byte[vertByteSize * m.vertexCount];
        var stagingFloats = new float[m.vertexCount * 4];

        Debug.Assert(m.vertexCount == m.vertices.Length);

        // Copy vertex data as contiguous runs by field.
        var offset = 0;
        offset = MemoryMapUtility.MapVector3ToBytes(m.vertexCount, bytes, 0, stagingFloats, m.vertices);

        if(hasNormal)
        {
            Debug.AssertFormat(m.vertices.Length == m.normals.Length, "vertices[{0}] != normals[{1}]", m.vertices.Length, m.normals.Length);
            offset += MemoryMapUtility.MapVector3ToBytes(m.vertexCount, bytes, offset, stagingFloats, m.normals);
        }

        if (hasUV1)
            offset += MemoryMapUtility.MapVector2ToBytes(m.vertexCount, bytes, offset, stagingFloats, m.uv);

        if (hasUV2)
            offset += MemoryMapUtility.MapVector2ToBytes(m.vertexCount, bytes, offset, stagingFloats, m.uv2);

        if(hasTangent)
            offset += MemoryMapUtility.MapVector4ToBytes(m.vertexCount, bytes, offset, stagingFloats, m.tangents);

        lm.verts.Stream = new MemoryStream(bytes, 0, offset, false, true);

        lm.vertexCount = m.vertexCount;

        lm.bounds = m.bounds;

        Profiler.EndSample();

        Profiler.EndSample();

        Profiler.BeginSample("Write Indices");

        var indices = m.triangles;

        lm.indexCount = indices.Length;
        var indexSizeInBytes = indices.Length * 2;
        bytes = new byte[indexSizeInBytes];
        var shortIdx = new ushort[indices.Length];

        for(var i=0; i<indices.Length; i++)
            shortIdx[i] = (ushort)indices[i];

        Buffer.BlockCopy(shortIdx, 0, bytes, 0, indexSizeInBytes);
        lm.indices.Stream = new MemoryStream(bytes, 0, indexSizeInBytes, false, true);

        Profiler.EndSample();

        for (var i = 0; i < m.subMeshCount; i++)
        {
            var lsm = new LevelSubMesh();
            lsm.start = (int)m.GetIndexStart(i);
            lsm.count = (int)m.GetIndexCount(i);
            lm.subMeshes.Add(lsm);
        }

        if(go.GetComponent<MeshCollider>() && go.GetComponent<MeshCollider>().enabled)
            lo.SetMeshCollider();

        if (mr && mr.enabled)
        {
            lo.SetMeshRenderer();

            // Lightmap settings.
            lm.lightmapIndex = mr.lightmapIndex;
            lm.lightmapScaleOffset = mr.lightmapScaleOffset;

            // Encode materials.
            foreach (var mrM in mr.sharedMaterials)
                lm.materials.Add(mapComp.ResolveMaterialName(mrM.name));
        }

        lo.mesh = lm;
    }

    bool EnsureMapComponentsLoaded()
    {
        if (mapComp == null)
            mapComp = Resources.Load<MapComponents>("MapComponents");
        if (mapComp == null)
        {
            Debug.Log("Could not find MapComponent in Resources folder");
            return false;
        }
        return true;
    }

}

#endif