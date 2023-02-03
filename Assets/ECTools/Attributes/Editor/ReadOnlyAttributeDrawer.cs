using UnityEngine;
using UnityEditor;

namespace ECTools.Attributes
{

    [CustomPropertyDrawer(typeof(ReadOnlyAttribute))]
    public class ReadOnlyAttributeDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            // Saving previous GUI enabled value
            var previousGUIState = GUI.enabled;

            // Disabling edit for property
            GUI.enabled = false;

            // Drawing Property
            EditorGUI.PropertyField(position, property, label);

            // Setting old GUI enabled value
            GUI.enabled = previousGUIState;
        }
    }

}