using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LightDebuger : MonoBehaviour
{

    public void ResetRotation()
    {
        transform.eulerAngles = new Vector3(90, 0, 0);
    }

    public void FocusInScene()
    {
        Selection.activeObject = gameObject;
        SceneView.FrameLastActiveSceneView();
    }

}
