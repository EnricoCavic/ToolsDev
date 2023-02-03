using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(LightDebuger))]
public class LightDebugerEditor : Editor
{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        var debuger = (LightDebuger)target;

        if (GUILayout.Button("Reset rotation", GUILayout.MaxWidth(100)))
        {
            debuger.ResetRotation();
        }
        
        if (GUILayout.Button("Focus in scene", GUILayout.MinHeight(130)))
        {
            debuger.FocusInScene();
        }

        

    }

}
