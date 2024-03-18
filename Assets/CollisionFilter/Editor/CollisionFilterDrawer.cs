using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UIElements;

namespace DefaultNamespace.Editor
{
    [CustomPropertyDrawer(typeof(CollisionFilter))]
    public class CollisionFilterDrawer : PropertyDrawer
    {
        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            var root = new VisualElement();
            // var conditionsProperty = property.FindPropertyRelative("_conditions");
            // var conditions = conditionsProperty.serializedObject.targetObject;
            // var label = new Label(conditions.GetType().ToString());
            // root.Add(label);

            
            root.Add(new Label("Some"));
            return root;
        }
    }
}