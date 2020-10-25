using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CadsConfig", menuName = "Table/CadsConfig")]
public class CadsConfig : ScriptableObject
{
    public string PATH;

    public List<Sprite> _sprites;

    private void OnGUI()
    {
        if (GUILayout.Button("DO IT"))
        {

        }
    }
}
