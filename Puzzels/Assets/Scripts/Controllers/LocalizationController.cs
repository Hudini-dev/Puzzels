using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LocalizationController : MonoBehaviour
{
    private string[] _lanquages;
    private string _lanquage;

    private string[,] _localizationData;
    private Dictionary<string, int> _keyLookup = new Dictionary<string, int>();

    private void Awake()
    {
        Initialize();

        Debug.Log(GetLocalizationString("PUZZEL_1_TITLE"));
    }

    private void Initialize()
    {
        TextAsset csvFile = (TextAsset)Resources.Load("Localization/Localization", typeof(TextAsset));
        if(csvFile != null)
        {
            _localizationData = CSVReader.SplitCsvGrid(csvFile.text);
            InitializeLookup();
        }
        else
        {
            Debug.LogError("CSV file is NULL");
        }
    }

    private void InitializeLanquages(string text)
    {
        var first = new StringReader(text).ReadLine()?.ToLower();
        _lanquages = CSVReader.SplitCsvLine(first);
    }

    private void InitializeLookup()
    {
        _keyLookup.Clear();
        var keysCount = _localizationData.GetLength(1);
        for(int i = 0; i < keysCount; i++)
        {
            if(_localizationData[0,i] != null)
            {
                _keyLookup[_localizationData[0, i].ToLower()] = i;
            }
        }
    }

    public string GetLocalizationString(string key)
    {
        return SearchForKey(key, 1);
    }

    private int SearchForLanquageIndex(string lanquage)
    {
        return Array.IndexOf(_lanquages, lanquage.ToLower());
    }

    private string SearchForKey(string key, int lanquageIndex)
    {
        if(_keyLookup.TryGetValue(key.ToLower(), out var index))
        {
            if(index > 0 && index < _localizationData.GetLength(1))
            {
                return _localizationData[lanquageIndex, index];
            }
        }

        return key;
    }
}
