using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SplineDrawer))]
public class SplineDrawViewer : Editor {
    
    void OnSceneGUI()
    {
        if(Event.current.type == EventType.MouseDown)
        {
            SplineDrawer drawer = target as SplineDrawer;
            Transform t = drawer.transform;
            if (Selection.activeTransform != t)
            {
                bool inChildren = false;
                foreach (Transform v in t)
                {
                    if (Selection.activeTransform == v)
                        inChildren = true;
                }
                if (!inChildren)
                    return;
            }

            Ray ray = HandleUtility.GUIPointToWorldRay(Event.current.mousePosition);
            GameObject o = new GameObject();
            SphereCollider sp = o.AddComponent<SphereCollider>();
            sp.radius = 0.5f;
            RaycastHit hit;
            foreach(Transform v in t)
            { 
                o.transform.position = v.position;
                if(sp.Raycast(ray, out hit, float.MaxValue))
                {
                    GUIUtility.hotControl = 0;
                    Selection.activeTransform = v;
                }
            }
            DestroyImmediate(o);
        }
    }


}
