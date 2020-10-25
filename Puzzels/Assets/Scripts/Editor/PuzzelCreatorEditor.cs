using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(PuzzelCreator))]
public class PuzzelCreatorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        var creator = (PuzzelCreator)target;
        if (GUILayout.Button("Save"))
        {
            //TODO: Save function
        }
        if (GUILayout.Button("Load"))
        {
            //TODO: Load function
        }
        if (GUILayout.Button("Change language"))
        {
            creator.Init();
        }
    }
}
