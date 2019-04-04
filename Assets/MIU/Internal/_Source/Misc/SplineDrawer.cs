using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SplineDrawer : MonoBehaviour {

    void OnDrawGizmos()
    {
        if(Selection.activeTransform != transform)
        {
            bool inChildren = false;
            foreach(Transform v in transform)
            {
                if (Selection.activeTransform == v)
                    inChildren = true;
            }
            if (!inChildren)
                return;
        }
        if (transform.childCount == 0)
            return;

        if (transform.childCount < 4)
            return;
        Vector3 pt0 = transform.GetChild(0).position;
        for (int i = 1; i < transform.childCount-2; i += 3)
        {
            Vector3 pt1 = transform.GetChild(i).position;
            Vector3 pt2 = transform.GetChild(i+1).position;
            Vector3 pt3 = transform.GetChild(i+2).position;


            Handles.color = Color.gray;
            Handles.DrawLine(pt0, pt1);
            Handles.DrawLine(pt2, pt3);
            ShowPoint(pt1, Color.gray, 0.35f);
            ShowPoint(pt3, Color.gray, 0.35f);
            ShowPoint(pt0, Color.blue, 0.5f);
            ShowPoint(pt2, Color.grey, 0.35f);

            Handles.DrawBezier(pt0, pt3, pt1, pt2, Color.blue, null, 2f);

            pt0 = pt3;
        }
    }

    void ShowPoint(Vector3 pos, Color c, float size)
    {
        Gizmos.color = c;
        Gizmos.DrawSphere(pos, size);

    }
}
