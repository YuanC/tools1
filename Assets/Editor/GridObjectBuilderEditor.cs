using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GridObjectBuilder))]
public class GridObjectBuilderEditor : Editor
{
    public override void OnInspectorGUI()
    {
        GridObjectBuilder gObjBuilder = (GridObjectBuilder)target;
        DrawDefaultInspector();
        
        if (GUILayout.Button("BuildObject"))
        {
            gObjBuilder.BuildObject();
        }
    }
}
