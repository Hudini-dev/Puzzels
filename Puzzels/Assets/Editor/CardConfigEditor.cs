using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(CadsConfig))]
public class CardConfigEditor : Editor
{
    private CadsConfig _target;

    public override void OnInspectorGUI()
    {
        _target = (CadsConfig)target;

        DrawDefaultInspector();

        if (GUILayout.Button("Build Object"))
        {
            DoIt();
        }
    }

    private void DoIt()
    {
        string _path = "Assets/Cards/Age of Ascension/ENG";
        _target._sprites = GetAtPath(_path);
    }

    public List<Sprite> GetAtPath(string path)
    {
        List<Sprite> sprites = new List<Sprite>();
        var objects = AssetDatabase.LoadAllAssetsAtPath(path);
        foreach(var obj in objects)
        {
            if(obj is Sprite sprite)
            {
                sprites.Add(sprite);
            }
        }

        return sprites;
    }
}
