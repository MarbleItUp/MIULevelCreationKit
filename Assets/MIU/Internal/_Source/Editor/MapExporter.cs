using System;
using System.Collections.Generic;
using UnityEngine;
using MIU;
using UnityEditor;
using System.IO;
using System.Reflection;

public class MapExporter : EditorWindow
{
    int ChapterIndex;
    int LevelIndex;

    float timeDelay=0;
    bool running;

    MapExporter()
    {
        titleContent = new GUIContent("Level Exporter");
    }

    private void OnGUI()
    {
        var bigLabel = new GUIStyle(GUI.skin.label);
        bigLabel.fontStyle = FontStyle.Bold;

        var bigButton = new GUIStyle(GUI.skin.button);
        bigButton.fontSize = bigLabel.fontSize;

        GUILayout.BeginVertical();

        GUILayout.Label("Export Level", bigLabel);

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Export", bigButton)) BakeScene();

        GUILayout.EndHorizontal();

        GUILayout.EndVertical();
    }

    private void Stop()
    {
        ChapterIndex = -1;
    }

    private void BakeScene()
    {
        var assembly = Assembly.GetAssembly(typeof(SceneView));
        var type = assembly.GetType("UnityEditor.LogEntries");
        var method = type.GetMethod("Clear");
        method.Invoke(new object(), null);
        LevelSerializer.failCause = "";
        Debug.Log("Starting Level Export");

        if(MapComponents.GetNumOf("SpawnPoint") == 0)
        {
            if (MapComponents.GetNumOf("StartPad") != 1)
            {
                LevelSerializer.failCause = "Singleplayer Level needs one StartPad!";
            }
            if (MapComponents.GetNumOf("EndPad") != 1)
            {
                LevelSerializer.failCause = "Singleplayer Level needs one EndPad!";
            }
            if (FindObjectsOfType<LevelTiming>().Length != 1)
            {
                LevelSerializer.failCause = "Singleplayer Level needs one Level Times object!";
            }
        }  
        else
        {
            if (MapComponents.GetNumOf("StartPad") > 0)
            {
                LevelSerializer.failCause = "Multiplayer Maps can't have StartPads.";
            }
            if (MapComponents.GetNumOf("EndPad") > 0)
            {
                LevelSerializer.failCause = "Multiplayer Maps can't have EndPads.";
            }
            if (FindObjectsOfType<LevelTiming>().Length > 0)
            {
                LevelSerializer.failCause = "Multiplayer Maps can't have timers.";
            }
        }

        if (MapComponents.GetNumOf("LevelBounds") != 1)
        {
            LevelSerializer.failCause = "Level needs one Level Bounds!";
        }

        var serializer = new LevelSerializer();
        ByteStream levelBits = new ByteStream();
        if (LevelSerializer.failCause.Length == 0)
            serializer.Serialize(ref levelBits);

        if(LevelSerializer.failCause.Length == 0)
        {
            string filePath = "Assets/" + LevelSerializer.GetCurrentSceneLevelId().Replace('_',' ') + ".level";

            FileStream file;
            if (!File.Exists(filePath))
                file = File.Create(filePath);
            else
                file = File.Open(filePath, FileMode.Truncate, FileAccess.Write);
            file.Write(levelBits.Buffer, 0, levelBits.Position);
            file.Close();

            Debug.Log("<color=green>Level Exported:</color> " + filePath);
        }
        else
            Debug.Log("<color=#ff3232>Export Failed:</color> " + LevelSerializer.failCause);
    }

    private Transform TestContainer = null;
   

    [MenuItem("Marble It Up/Level Export")]
    static void Baker()
    {
        var w = GetWindow<MapExporter>();
        w.ShowTab();
    }
}
