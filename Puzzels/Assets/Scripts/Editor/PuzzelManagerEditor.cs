using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(PuzzelManager))]
public class PuzzelManagerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        var manager = (PuzzelManager)target;
        if (GUILayout.Button("Save"))
        {
            manager.SaveToFile();
        }
        if (GUILayout.Button("Load"))
        {
            manager.LoadFromFile();
        }
    }
}
