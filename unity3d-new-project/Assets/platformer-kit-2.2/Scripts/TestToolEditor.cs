using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(TestTool))]
public class TestToolEditor : Editor
{
    SerializedProperty myString;

    private void OnEnable()
    {
        myString = serializedObject.FindProperty("myString");
    }
    public override void OnInspectorGUI()
    {

    }
}
