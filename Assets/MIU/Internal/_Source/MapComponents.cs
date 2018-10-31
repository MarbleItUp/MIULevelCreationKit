using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

[Serializable]
public class MapObject
{
    public string name;
    public GameObject reference;
}

[Serializable]
public class MapMaterial
{
    public Material material;
    public string name;
}

public class MapComponents : ScriptableObject {

    public Material defaultMaterial;
    public MapMaterial[] materials;
    public MapObject[] objects;
    public Material[] skyboxes;
    public Sprite[] tutorialSprites;

    public string ResolveMaterialName(string matName)
    {
        return matName;
    }

    public string ResolveMaterialToId(Material material)
    {
        if(!material)
        {
            Debug.LogError("Got a null material!");
            return "NONE";
        }

        foreach(var mat in materials)
        {
            if(mat.material == material)
                return mat.name;
        }

        return material.name;
    }

    public string ResolveNameToPrefabID(string objectName)
    {
        objectName = FixName(objectName);
        foreach (var note in objects)
        {
            if (note.name != objectName)
                continue;
            return note.name;
        }
        Debug.Log("No prefab found: " + objectName);
        return objectName;
    }

    public static int GetNumOf(string objectName)
    {
        GameObject[] obj = FindObjectsOfType<GameObject>();
        int num = 0;
        foreach (GameObject o in obj)
        {
            if (FixName(o.name) == objectName)
                num++;
        }
        return num;
    }

    public static string FixName(string name)
    {
        Regex regex = new Regex("\\ \\(\\d*\\)");
        return regex.Replace(name, "");
    }

    public int ResolveSpriteToID(Sprite sprt)
    {
        return 0;
    }

}
