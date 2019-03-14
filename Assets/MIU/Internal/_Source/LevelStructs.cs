using System;
using System.Collections.Generic;
using UnityEngine;

namespace MIU
{
    // Describe the index buffer range and material to render
    // a submesh.
    public class LevelSubMesh
    {
        public int start;
        public int count;
        public string material;
    }

    public class LevelMesh
    {
        [Flags]
        public enum MeshFlags
        {
            UV1 = 1 << 0,
            UV2 = 1 << 1,
            Normal = 1 << 2,
            IsStatic = 1 << 3,
            Tangent = 1 << 4,
        }

        public Bounds bounds;

        public MeshFlags Flags = 0;

        public int vertexCount;
        public SimpleBuffer verts = new SimpleBuffer();

        public int indexCount;
        public SimpleBuffer indices = new SimpleBuffer();
        public List<LevelSubMesh> subMeshes = new List<LevelSubMesh>();

        public List<string> materials = new List<string>();
        public int lightmapIndex = -1;
        public Vector4 lightmapScaleOffset;

        public bool HasNormal
        {
            get
            {
                return (Flags & MeshFlags.Normal) != 0;
            }
        }

        public bool HasUV1
        {
            get
            {
                return (Flags & MeshFlags.UV1) != 0;
            }
        }

        public bool HasUV2
        {
            get
            {
                return (Flags & MeshFlags.UV2) != 0;
            }
        }

        public bool HasTangents
        {
            get
            {
                return (Flags & MeshFlags.Tangent) != 0;
            }
        }

        public bool IsStatic
        {
            get
            {
                return (Flags & MeshFlags.IsStatic) != 0;
            }
        }

    }


    public class LevelObject
    {
        public string name;
        public Vector3 position = Vector3.zero;
        public Quaternion rotation = Quaternion.identity;
        public Vector3 scale = Vector3.one;

        public LevelMesh mesh = new LevelMesh();
        public int LargestChildVertexCount = 0;

        public string prefabItem;
        public SimpleBuffer serializedContent = new SimpleBuffer();
        public Dictionary<string, object> properties = new Dictionary<string, object>();

        public List<LevelObject> children = new List<LevelObject>();

        public const string MESH_RENDERER = "MeshRenderer";

        public const string MESH_COLLIDER = "MeshCollider";

        public const string SPAWN_DRIFTING_OBJECTS = "SpawnDriftingObjects";
        public const string SPAWN_DRIFTING_OBJECTS_TEMPLATE = SPAWN_DRIFTING_OBJECTS + "_Template";

        public const string MESH_TUNNEL_ANIMATOR = "MeshTunnelAnimator";
        public const string MESH_TUNNEL_ANIMATOR_MATERIAL = MESH_TUNNEL_ANIMATOR + "_MaterialID";
        public const string MESH_TUNNEL_ANIMATOR_DISPLAYMESH = MESH_TUNNEL_ANIMATOR + "_DisplayMesh";

        public const string PARTICLE_SYSTEM = "ParticleSystem";
        public const string PARTICLE_SYSTEM_MATERIAL = PARTICLE_SYSTEM + "_Material";

        public const string BOX_COLLIDER = "BoxCollider";
        public const string BOX_COLLIDER_CENTER = BOX_COLLIDER + "_Center";
        public const string BOX_COLLIDER_SIZE = BOX_COLLIDER + "_Size";
        public const string BOX_COLLIDER_ISTRIGGER = BOX_COLLIDER + "_IsTrigger";

        public const string TUTORIAL = "Tutorial";
        public const string TUTORIAL_SHOWONCE = TUTORIAL + "_ShowOnce";
        public const string TUTORIAL_GRAPHIC = TUTORIAL + "_Graphic";
        public const string TUTORIAL_MESSAGE = TUTORIAL + "_Message";

        public const string MOVER = "Mover";
        public const string MOVER_MODE = MOVER + "_Mode";
        public const string MOVER_COLLAPSETRIGGERED = MOVER + "_CollapseTriggered";
        public const string MOVER_STARTOFFSETTIME = MOVER + "_StartOffsetTime";
        public const string MOVER_DELTA = MOVER + "_Delta";
        public const string MOVER_DELTAROTATION = MOVER + "_DeltaRotation";
        public const string MOVER_PAUSETIME = MOVER + "_PauseTime";
        public const string MOVER_MOVETIME = MOVER + "_MoveTime";
        public const string MOVER_MOVEFIRST = MOVER + "_MoveFirst";
        public const string MOVER_SPLINESPEED = MOVER + "_SplineSpeed";
        public const string MOVER_KEEPORIENTATION = MOVER + "_KeepOrientation";

        public const string MOVER_ENABLEBOB = MOVER + "_EnableBob";
        public const string MOVER_BOBOFFSET = MOVER + "_BobOffset";
        public const string MOVER_BOBPERIOD = MOVER + "_BobPeriod";
        public const string MOVER_BOBVECTOR = MOVER + "_BobVector";

        public const string SPLINE = "Spline";
        public const string SPLINE_COUNT = SPLINE + "_Count";
        public const string SPLINE_POSITION = SPLINE + "_Pos";

        public const string CHECKPOINT = "Checkpoint";

        public Vector3 GetVector3(string key)
        {
            return new Vector3(
                (float)properties[key + ".x"],
                (float)properties[key + ".y"],
                (float)properties[key + ".z"]
                );
        }

        public void SetVector3(string key, Vector3 val)
        {
            properties[key + ".x"] = val.x;
            properties[key + ".y"] = val.y;
            properties[key + ".z"] = val.z;
        }

        public void ClearMeshCollider()
        {
            if (properties.ContainsKey(MESH_COLLIDER))
                properties.Remove(MESH_COLLIDER);
        }

        public void SetMeshCollider()
        {
            properties[MESH_COLLIDER] = true;
        }

        public void SetMeshRenderer()
        {
            properties[MESH_RENDERER] = true;
        }

    }

    public class LevelScene
    {
        public string name;
        public LevelObject root = new LevelObject();

        public int skyboxId;
        public Vector3 sunDirection;

        // Preview camera info.
        public Vector3 previewPosition;
        public Quaternion previewOrientation;
    }

}