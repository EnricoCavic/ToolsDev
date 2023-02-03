using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace ECTools.Attributes
{

    [CustomPropertyDrawer(typeof(RandomizeAttribute))]
    public class RandomizeAttributeDrawer : PropertyDrawer
    {
        const float FIELD_HEIGHT = 16f;

        int maxLines;
        int currentLine;

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return FIELD_HEIGHT * maxLines;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            currentLine = 0;

            EditorGUI.LabelField(NewFieldPosition(position, FIELD_HEIGHT), label, new GUIContent(property.floatValue.ToString()));
            EditorGUI.LabelField(NewFieldPosition(position, FIELD_HEIGHT), label, new GUIContent(property.floatValue.ToString()));
            if(GUI.Button(NewFieldPosition(position, FIELD_HEIGHT), "Randomize"))
            {
                RandomizeAttribute randomizeAttribute = (RandomizeAttribute)attribute;
                property.floatValue = Random.Range(randomizeAttribute.min, randomizeAttribute.max);
            }


        }

        private Rect NewFieldPosition(Rect _position, float _height)
        {
            float yPosition = _position.y + currentLine * _height;
            Rect labelPosition = new Rect(_position.x, yPosition, _position.width, _height);
            currentLine++;
            if (currentLine > maxLines) maxLines = currentLine;
            return labelPosition;
        }
    }
}