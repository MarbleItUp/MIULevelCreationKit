using System;
using System.Collections;
using System.Collections.Generic;
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

    public void UpdatePlatformMaterials()
    {

    }

    public string ResolveMaterialName(string matName)
    {
        return matName;
    }

    public string ResolveMaterialToId(Material material, bool dontAdd = false)
    {
        if(!material)
        {
            Debug.LogError("Got a null material!");
            return materials[0].name;
        }

        foreach(var mat in materials)
        {
            if(mat.material == material)
                return mat.name;
        }

        if(dontAdd)
            return null;
        
        var name = material.name;
        var suffix = 0;
        var searchName = name;
        return searchName;
    }

    public Material ResolveMaterialFromID(string name)
    {
        foreach (var mat in materials)
        {
            if (mat.name == name)
                return mat.material;
        }
        return null;
    }

    public string ResolveNameToPrefabID(string objectName)
    {
        foreach (var note in objects)
        {
            if (note.name != objectName)
                continue;
            return note.name;
        }
        Debug.LogError("ResolveNameToPrefabID - Couldn't find '" + objectName + "' in prefab list.");
        return objectName;
    }

    public GameObject ResolveIdToGameObject(string id)
    {
        foreach (var note in objects)
        {
            if (note.name != id)
                continue;

            return note.reference;
        }        
        return null;
    }

    public int ResolveSpriteToID(Sprite sprt)
    {
        for(int i=0; i<tutorialSprites.Length; i++)
        {
            if (sprt == tutorialSprites[i])
                return i;
        }
        return 0;
    }

}
