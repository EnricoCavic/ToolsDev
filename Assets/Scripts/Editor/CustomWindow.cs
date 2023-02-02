using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CustomWindow : EditorWindow
{
    [MenuItem("Window/Nova janela customizada", false, 0)]
    public static void OpenWindow()
    {
        GetWindow(typeof(CustomWindow));
    }
}
