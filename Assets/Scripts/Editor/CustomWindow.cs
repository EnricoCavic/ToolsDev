using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class CustomWindow : EditorWindow
{
    // apenas vari�veis est�ticas s�o salvas entre instancias da janela
    static Volume volume1;
    static Volume volume2;



    // tamb�m � poss�vel criar uma aba nova com essa tag
    [MenuItem("Window/Nova janela customizada", false, 0)]
    public static void OpenWindow()
    {
        // abre uma nova janela do tipo do par�metro
        GetWindow(typeof(CustomWindow));
    }

    private void OnGUI()
    {
        ObjectField();
        Button();
        EditorGUILayout.Space(10, true);
        TextArea();

    }

    private static void Button()
    {
        // btn retorna true se for clicado
        if (GUILayout.Button("Clear volumes"))
        {
            volume1 = null;
            volume2 = null;
        }
    }

    private static void ObjectField()
    {
        // cria uma janela de busca com os objs do tipo especificado
        // objeto no param da fun��o � o objeto que o editor motra como display
        // o objeto de retorno � o objeto que usu�rio inseriu no editor
        volume1 = (Volume)EditorGUILayout.ObjectField("This is volume 1", volume1, typeof(Volume), true);
        volume2 = (Volume)EditorGUILayout.ObjectField("This is volume 2", volume2, typeof(Volume), true);
    }

    string nonStaticTxt;
    string defalutTxtArea = "This is a non static string";
    private void TextArea()
    {
        // string no param da fun��o � a string que o editor motra como display
        // string de retorno � a string que usu�rio inseriu no editor
        nonStaticTxt = EditorGUILayout.TextArea(nonStaticTxt, GUILayout.Height(position.height / 2));
        if (string.IsNullOrWhiteSpace(nonStaticTxt))
        {
            nonStaticTxt = defalutTxtArea;
        }
    }
}
