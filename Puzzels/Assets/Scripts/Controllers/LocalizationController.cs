using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static class LocalizationController
{
    private static string[] _lanquages;
    private static string _lanquage;

    private static string[,] _localizationData;
    private static Dictionary<string, int> _keyLookup = new Dictionary<string, int>();

    private static bool _initialized;

    private static void Initialize()
    {
        TextAsset csvFile = (TextAsset)Resources.Load("Localization/Localization", typeof(TextAsset));
        if(csvFile != null)
        {
            _localizationData = CSVReader.SplitCsvGrid(csvFile.text);
            InitializeLookup();
            _initialized = true;
        }
        else
        {
            Debug.LogError("CSV file is NULL");
        }
    }

    private static void InitializeLanquages(string text)
    {
        var first = new StringReader(text).ReadLine()?.ToLower();
        _lanquages = CSVReader.SplitCsvLine(first);
    }

    private static void InitializeLookup()
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

    public static string GetLocalizationString(string key)
    {
        if(!_initialized)
        {
            Initialize();
        }
        return SearchForKey(key, 1);
    }

    private static int SearchForLanquageIndex(string lanquage)
    {
        return Array.IndexOf(_lanquages, lanquage.ToLower());
    }

    private static string SearchForKey(string key, int lanquageIndex)
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
