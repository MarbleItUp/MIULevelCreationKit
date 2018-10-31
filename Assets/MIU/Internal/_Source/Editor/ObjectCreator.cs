using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Reflection;
using Object = UnityEngine.Object;

public class ObjectCreator : Editor {

    #region Pickups

    [MenuItem("Marble It Up/Create/Pickups/Gem")]
    static void CreateGem()
    {
        Create("Gem", "gem_icon", "Gameplay");
    }

    [MenuItem("Marble It Up/Create/Pickups/Super Jump")]
    static void CreateSJ()
    {
        Create("Jump", "sjump_icon", "Gameplay");
    }

    [MenuItem("Marble It Up/Create/Pickups/Featherfall")]
    static void CreateFF()
    {
        Create("Featherfall", "feather_icon", "Gameplay");
    }

    [MenuItem("Marble It Up/Create/Pickups/Boost")]
    static void CreateSS()
    {
        Create("Boost", "boost_icon", "Gameplay");
    }

    [MenuItem("Marble It Up/Create/Pickups/Time Travel")]
    static void CreateTT()
    {
        Create("TimeTravel", "ttravel_icon", "Gameplay");
    }

    [MenuItem("Marble It Up/Create/Pickups/Trophy")]
    static void CreateTrophy()
    {
        Create("Easter Egg", "trophy_icon", "Gameplay", true);
    }

    #endregion

    #region Core

    [MenuItem("Marble It Up/Create/Core/Level Bounds")]
    static void CreateLvlBounds()
    {
        GameObject o = Create("LevelBounds", "", "Gameplay", true);
        if (o != null)
        {
            o.tag = "LevelBounds";
            BoxCollider bc = o.AddComponent<BoxCollider>();
            bc.isTrigger = true;
            bc.size = new Vector3(150, 50, 150);
        }
    }

    [MenuItem("Marble It Up/Create/Core/Start Pad")]
    static void CreateStartPad()
    {
        Create("StartPad", "startpad_icon", "Gameplay", true);
    }

    [MenuItem("Marble It Up/Create/Core/End Pad")]
    static void CreateEndPad()
    {
        Create("EndPad", "endpad_icon", "Gameplay", true);
    }

    [MenuItem("Marble It Up/Create/Core/Level Timing")]
    static void CreateTimingObj()
    {
        GameObject o = Create("LevelTiming", "", "", true);
        if (o != null)
        {
            LevelTiming bc = o.AddComponent<LevelTiming>();
        }
    }

    #endregion

    #region Gameplay

    [MenuItem("Marble It Up/Create/Gameplay/Bumper")]
    static void CreateBumper()
    {
        Create("Bumper", "bumper_icon", "Gameplay");
    }

    [MenuItem("Marble It Up/Create/Gameplay/Checkpoint")]
    static void CreateCheckpoint()
    {
        GameObject o = Create("CheckPoint", "checkpoint_icon", "Gameplay");

        BoxCollider bc = o.AddComponent<BoxCollider>();
        bc.isTrigger = true;
        bc.size = new Vector3(5, 3, 5);
        bc.center = new Vector3(0, 1.5f, 0);
    }

    #endregion

    #region Visual

    [MenuItem("Marble It Up/Create/Signs/Curvy")]
    static void CreateSignCurve()
    {
        Create("Sign_Curvy", "sign_curve", "Skybox");
    }

    [MenuItem("Marble It Up/Create/Signs/Dropoff")]
    static void CreateSignDrop()
    {
        Create("Sign_DropOff", "sign_drop", "Skybox");
    }

    [MenuItem("Marble It Up/Create/Signs/Fork")]
    static void CreateSignFork()
    {
        Create("Sign_Fork", "sign_fork", "Skybox");
    }

    [MenuItem("Marble It Up/Create/Signs/Hazard")]
    static void CreateSignHazard()
    {
        Create("Sign_Hazard", "sign_hazard", "Skybox");
    }

    [MenuItem("Marble It Up/Create/Signs/Icey")]
    static void CreateSignIce()
    {
        Create("Sign_Icy", "sign_ice", "Skybox");
    }

    [MenuItem("Marble It Up/Create/Signs/Steep")]
    static void CreateSignSteep()
    {
        Create("Sign_Steep", "sign_steep", "Skybox");
    }

    [MenuItem("Marble It Up/Create/Signs/Left Turn")]
    static void CreateSignLeft()
    {
        Create("Sign_TurnLeft", "sign_left", "Skybox");
    }

    [MenuItem("Marble It Up/Create/Signs/Right Turn")]
    static void CreateSignRight()
    {
        Create("Sign_TurnRight", "sign_right", "Skybox");
    }

    [MenuItem("Marble It Up/Create/Signs/Continuous Turn")]
    static void CreateSignContinuous()
    {
        Create("Sign_ContinuousTurn", "sign_continuous", "Skybox");
    }

    [MenuItem("Marble It Up/Create/FX/Big Crystal")]
    static void CreateBigCrystal()
    {
        Create("GiantCrystal", "bigcrystal_icon", "Skybox");
    }
    #endregion

    #region Multiplayer

    [MenuItem("Marble It Up/Create/Multiplayer/Spawn Point")]
    static void CreateSpawnPoint()
    {
        Create("SpawnPoint", "mpspawn_icon", "Multiplayer", true);
    }

    #endregion

    [MenuItem("Marble It Up/Create/Util/Marble Size Reference")]
    static void CreateMableRef()
    {
        GameObject o = GameObject.Find("marble_size_reference");
        if (o != null)
        {
            Debug.LogError("Size reference already exists!");
            Selection.activeGameObject = o;
            return;
        }

        o = Instantiate(Resources.Load<GameObject>("marble_size_reference"));
        o.transform.name = "marble_size_reference";
        Selection.activeGameObject = o;
    }

    [MenuItem("Marble It Up/Set Up Lighting")]
    static void SetupLighting()
    {
        //Sky
        RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Flat;
        RenderSettings.ambientIntensity = 1f;
        RenderSettings.skybox = Resources.Load<Material>("Sky001");

        //Lightmap Core
#if UNITY_2017_3_OR_NEWER
        LightmapEditorSettings.lightmapper = LightmapEditorSettings.Lightmapper.Enlighten;
#else
        LightmapEditorSettings.lightmapper = LightmapEditorSettings.Lightmapper.Radiosity;
#endif
        Lightmapping.realtimeGI = false;
        Lightmapping.bakedGI = true;
        Lightmapping.giWorkflowMode = Lightmapping.GIWorkflowMode.OnDemand;
        LightmapSettings.lightmapsMode = LightmapsMode.NonDirectional;
        SetBool("m_LightmapEditorSettings.m_FinalGather", false);
        SetFloat("m_GISettings.m_AlbedoBoost", 2);

        //Ambient Occlusion
        LightmapEditorSettings.aoMaxDistance = 8;
        LightmapEditorSettings.aoExponentDirect = 4;
        LightmapEditorSettings.aoExponentIndirect = 4;
        LightmapEditorSettings.enableAmbientOcclusion = true;

        //Texture Generation
        LightmapEditorSettings.bakeResolution = 4;
        SetFloat("m_LightmapEditorSettings.m_Resolution", 2);
        LightmapEditorSettings.padding = 2;
        Lightmapping.bounceBoost = 2;
        LightmapEditorSettings.maxAtlasHeight = 1024;
        LightmapEditorSettings.maxAtlasWidth = 1024;
        SetBool("m_LightmapEditorSettings.m_TextureCompression", true);


        //Setup Directional Light
        Light light = FindObjectOfType<Light>();
        if(light == null)
        {
            GameObject o = new GameObject("Sun");
            light = o.AddComponent<Light>();
            light.type = LightType.Directional;
        }
        light.lightmapBakeType = LightmapBakeType.Mixed;
        light.intensity = 1;
        light.color = new Color(1, 244 / 255f, 214 / 255f);
        light.bounceIntensity = 2;
        light.shadows = LightShadows.Soft;
        light.shadowStrength = 1;
        GameObject staticObj = GameObject.Find("Static");
        if (staticObj == null)
            staticObj = new GameObject("Static");
        GameObject lighting = GameObject.Find("Lighting");
        if (lighting == null)
            lighting = new GameObject("Lighting");
        if (lighting.transform.parent != staticObj.transform)
            lighting.transform.SetParent(staticObj.transform);
        lighting.transform.localPosition = Vector3.zero;
        lighting.transform.localEulerAngles = Vector3.zero;
        light.transform.SetParent(lighting.transform);
        light.transform.localPosition = Vector3.zero;
        light.transform.localEulerAngles = new Vector3(50, -30, 0);
        light.gameObject.name = "Sun";
        light.gameObject.isStatic = true;
    }

    static GameObject Create(string itemName, string icon, string holderName, bool unique=false)
    {
        if(unique)
        {
            GameObject o = GameObject.Find(itemName);
            if(o != null)
            {
                Debug.LogError(itemName + " already exists!");
                Selection.activeGameObject = o;
                return null;
            }
        }

        GameObject obj = new GameObject(itemName);
        SetIcon(obj, icon);
        if(holderName != null && holderName.Length > 0)
        {
            GameObject holder = GameObject.Find(holderName);
            if(holder == null)
                holder = new GameObject(holderName);

            obj.transform.SetParent(holder.transform);
        }
        Selection.activeGameObject = obj;
        return obj;
    }

    static void SetIcon(GameObject o, string icon)
    {
        Texture2D ico = Resources.Load<Texture2D>(icon);
        if (ico != null)
            SetIcon(o, ico);
    }

    private static void SetIcon(GameObject gObj, Texture2D texture)
    {
        var ty = typeof(EditorGUIUtility);
        var mi = ty.GetMethod("SetIconForObject", BindingFlags.NonPublic | BindingFlags.Static);
        mi.Invoke(null, new object[] { gObj, texture });
    }

#region Lightmap Syste.Reflection Work

    public static void SetFloat(string name, float val)
    {
        ChangeProperty(name, property => property.floatValue = val);
    }

    public static void SetInt(string name, int val)
    {
        ChangeProperty(name, property => property.intValue = val);
    }

    public static void SetBool(string name, bool val)
    {
        ChangeProperty(name, property => property.boolValue = val);
    }

    public static void ChangeProperty(string name, Action<SerializedProperty> changer)
    {
        var lightmapSettings = getLighmapSettings();
        var prop = lightmapSettings.FindProperty(name);
        if (prop != null)
        {
            changer(prop);
            lightmapSettings.ApplyModifiedProperties();
        }
        else Debug.LogError("lighmap property not found: " + name);
    }

    static SerializedObject getLighmapSettings()
    {
        var getLightmapSettingsMethod = typeof(LightmapEditorSettings).GetMethod("GetLightmapSettings", BindingFlags.Static | BindingFlags.NonPublic);
        var lightmapSettings = getLightmapSettingsMethod.Invoke(null, null) as Object;
        return new SerializedObject(lightmapSettings);
    }
#endregion
}
