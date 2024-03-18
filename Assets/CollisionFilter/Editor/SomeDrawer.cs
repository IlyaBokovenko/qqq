using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace DefaultNamespace.Editor
{
    [CustomPropertyDrawer(typeof(Some))]
    public class SomeDrawer : PropertyDrawer
    {
        // public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        // {
        //     EditorGUI.PropertyField(position, property, label, true);
        // }

        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            var root = new VisualElement();
            // var xProperty = property.FindPropertyRelative("x");
            // var xField = new PropertyField(xProperty);
            // root.Add(xField);
            root.Add(new Label("AAAA"));
            return root;
        }
    }
}