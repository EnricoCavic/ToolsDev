using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CustomWindow : EditorWindow
{

    // tamb�m � poss�vel criar uma aba nova com essa tag
    [MenuItem("Window/Nova janela customizada", false, 0)]
    public static void OpenWindow()
    {
        // abre uma nova janela do tipo do par�metro
        GetWindow(typeof(CustomWindow));
    }

    private void OnGUI()
    {
        if( GUILayout.Button("A wild button appeared"))
        {
            Debug.Log("It's pikachu!");
        }
        
    }
}
