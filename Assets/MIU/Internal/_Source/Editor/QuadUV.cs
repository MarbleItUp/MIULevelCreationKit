using UnityEngine;
using UnityEditor;
using System.Collections;
using UnityEngine.ProBuilder;
using System.Collections.Generic;

public class QuadUV : EditorWindow
{

    [MenuItem("Marble It Up/Quad UV")]
    static void OpenWindow()
    {
        var w = GetWindow<QuadUV>();
        GUIContent titleContent = new GUIContent("MIU ProBuilder");
        w.titleContent = titleContent;
        w.ShowTab();
    }

    void OnGUI()
    {
        if (GUILayout.Button("Quad UV Faces"))
        {
            ProcessQuadUVSelected();
        }
        if (GUILayout.Button("Quad UV Strip"))
        {
            ProcessQuadUVStripSelected();
        }
        
    }

    [MenuItem("Tools//Actions/Quad UV - Selection", false, 20)]
    public static void ProcessQuadUVSelected()
    {
        List<ProBuilderMesh> selObjs = new List<ProBuilderMesh>();
        foreach(var v in Selection.transforms)
        {
            ProBuilderMesh p = v.GetComponent<ProBuilderMesh>();
            if (p != null)
                selObjs.Add(p);
        }
        ProBuilderMesh[] sel = selObjs.ToArray();
        ProcessQuadUV(sel);
    }

    [MenuItem("Tools/Actions/Quad UV Strip - Selection", false, 20)]
    public static void ProcessQuadUVStripSelected()
    {
        List<ProBuilderMesh> selObjs = new List<ProBuilderMesh>();
        foreach (var v in Selection.transforms)
        {
            ProBuilderMesh p = v.GetComponent<ProBuilderMesh>();
            if (p != null)
                selObjs.Add(p);
        }
        ProBuilderMesh[] sel = selObjs.ToArray();
        ProcessQuadUVStrip(sel);
    }

    static bool ProcessQuadUV(ProBuilderMesh[] selected)
    {
        Undo.RecordObjects(selected, "Quad UV");
        var facesValid = 0;
        var facesInvalid = 0;
        var updatedFaces = new List<Face>();
        for (int i = 0; i < selected.Length; i++)
        {
            var obj = selected[i];
            List<Vector4> uv = new List<Vector4>();
            obj.GetUVs(0, uv);
            var faces = obj.GetSelectedFaces();

            updatedFaces.Clear();
            for (var fi = 0; fi < faces.Length; fi++)
            {
                if (EditorUtility.DisplayCancelableProgressBar(
                        "Processing faces",
                        "pb_Object: " + obj.name + " " + (fi + 1) + " / " + faces.Length,
                        (i + (
                            (float)(fi + 1) / faces.Length
                        )) / selected.Length
                    ))
                {
                    EditorUtility.ClearProgressBar();
                    Debug.LogWarning("User canceled Quad UV processing.");
                    return false;
                }

                var face = faces[fi];
                var indices = face.ToQuad();
                if (indices != null)
                {
                    facesValid++;
                    face.manualUV = true;
                    uv[indices[0]] = new Vector2(0, 0);
                    uv[indices[1]] = new Vector2(0, 1);
                    uv[indices[2]] = new Vector2(1, 1);
                    uv[indices[3]] = new Vector2(1, 0);
                    updatedFaces.Add(face);
                }
                else
                {
                    facesInvalid++;
                }
            }

            obj.SetUVs(0, uv);
            obj.ToMesh();
            obj.Refresh();
        }

        // Rebuild the pb_Editor caches
        UnityEditor.ProBuilder.ProBuilderEditor.Refresh();

        Debug.Log("Quad UV Finished\nMeshes: " + selected.Length + "\nFaces: " + facesValid + "\nSkipped Faces: " + facesInvalid);

        EditorUtility.ClearProgressBar();
        return true;
    }

    static bool ProcessQuadUVStrip(ProBuilderMesh[] selected)
    {
        Undo.RecordObjects(selected, "Quad UV Strip");
        var facesValid = 0;
        var facesInvalid = 0;
        var updatedFaces = new List<Face>();
        for (int i = 0; i < selected.Length; i++)
        {
            var obj = selected[i];
            var vertices = obj.positions;
            List<Vector4> uv = new List<Vector4>();
            obj.GetUVs(0, uv);
            var faces = obj.GetSelectedFaces();

            updatedFaces.Clear();

            var totalLength = 0f;
            for (var fi = 0; fi < faces.Length; fi++)
            {
                if (EditorUtility.DisplayCancelableProgressBar(
                        "Processing faces",
                        "pb_Object: " + obj.name + " " + (fi + 1) + " / " + faces.Length,
                        (i + (
                            (float)(fi + 1) / faces.Length
                        )) / selected.Length
                    ))
                {
                    EditorUtility.ClearProgressBar();
                    Debug.LogWarning("User canceled Quad UV Strip processing.");
                    return false;
                }

                var face = faces[fi];
                var indices = face.ToQuad();

                // Assume invalid for flatter flow control with continue
                // down below
                facesInvalid++;

                if (indices == null) continue;
                if (faces.Length < 2) continue;

                // Find the neighbor in front or behind
                Face neighborFace = null;
                var lastInStrip = false;
                if (fi < faces.Length - 1)
                {
                    neighborFace = faces[fi + 1];
                }
                else if (fi > 0)
                {
                    neighborFace = faces[fi - 1];
                    lastInStrip = true;
                }

                if (neighborFace == null) continue;
                var neighbor = neighborFace.ToQuad();
                if (neighbor == null) continue;
                var vertexNum = 4;

                var faceIndexA = -1;
                var faceIndexB = -1;
                var neighborIndexA = -1;
                var neighborIndexB = -1;
                // Find the two vertices shared with neighbor
                for (var vi = 0; vi < vertexNum; vi++)
                {
                    var cv = vertices[indices[vi]];
                    for (var vj = 0; vj < vertexNum; vj++)
                    {
                        var nv = vertices[neighbor[vj]];
                        if (cv.Equals(nv))
                        {
                            if (faceIndexA == -1)
                            {
                                faceIndexA = vi;
                                neighborIndexA = vj;
                            }
                            else if (faceIndexB == -1)
                            {
                                faceIndexB = vi;
                                neighborIndexB = vj;
                            }
                        }
                    }
                }

                if (faceIndexA == -1 || faceIndexB == -1) continue;

                var faceA = vertices[indices[faceIndexA]];
                var faceB = vertices[indices[faceIndexB]];

                // Set the other two vertices to be the ones left after the
                // first two in the quad
                var faceIndexC = (faceIndexA + 1) % 4;
                if (faceIndexC == faceIndexB) faceIndexC = (faceIndexC + 1) % 4;
                var faceIndexD = faceIndexC;
                for (var di = 0; di < vertexNum; di++)
                {
                    faceIndexD = (faceIndexD + 1) % 4;
                    if (faceIndexD == faceIndexA) continue;
                    if (faceIndexD == faceIndexB) continue;
                    break;
                }

                // Get the distance from the first shared vertex (A) to both
                // the opposite vertices
                var sqrDistAC = Vector3.SqrMagnitude(vertices[indices[faceIndexC]] - faceA);
                var sqrDistAD = Vector3.SqrMagnitude(vertices[indices[faceIndexD]] - faceA);

                // Flip the opposite vertices if they form a cross instead
                // of a U shape, so UVs are laid out straight and
                // not crossed
                if (sqrDistAC < sqrDistAD)
                {
                    var c = faceIndexC;
                    faceIndexC = faceIndexD;
                    faceIndexD = c;
                }
                var faceC = vertices[indices[faceIndexC]];
                var faceD = vertices[indices[faceIndexD]];

                // Get the approximate length of the quad/face in the strip
                // that is used for the UV
                var faceSharedMid = (faceA + faceB) / 2f;
                var faceOppositeMid = (faceC + faceD) / 2f;
                var faceLength = Vector3.Distance(faceOppositeMid, faceSharedMid);

                // Flip the coordinates for the last face in the strip as
                // it refers to the previous neighbor, not the next one
                if (lastInStrip)
                {
                    var c = faceIndexC; var d = faceIndexD;
                    faceIndexC = faceIndexA;
                    faceIndexD = faceIndexB;
                    faceIndexA = c;
                    faceIndexB = d;
                }

                face.manualUV = true;
                uv[indices[faceIndexC]] = new Vector2(totalLength, 0);
                uv[indices[faceIndexD]] = new Vector2(totalLength, 1);
                totalLength += faceLength;
                uv[indices[faceIndexA]] = new Vector2(totalLength, 1);
                uv[indices[faceIndexB]] = new Vector2(totalLength, 0);
                updatedFaces.Add(face);

                // At this point the face was placed successfully, so fix
                // the counts
                facesInvalid--;
                facesValid++;
            }

            obj.SetUVs(0, uv);
            obj.ToMesh();
            obj.Refresh();
        }

        // Rebuild the pb_Editor caches
        UnityEditor.ProBuilder.ProBuilderEditor.Refresh();

        Debug.Log("Quad UV Strip Finished\nMeshes: " + selected.Length + "\nFaces: " + facesValid + "\nSkipped Faces: " + facesInvalid);

        EditorUtility.ClearProgressBar();
        return true;
    }
}