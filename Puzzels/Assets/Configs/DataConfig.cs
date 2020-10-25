using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DataConfig", menuName = "Table/DataConfig")]
public class DataConfig : ScriptableObject
{
    [SerializeField] private List<LanguageName> _languageNames;
    [SerializeField] private List<ExpansionName> _additionNames;
    [SerializeField] private List<HouseIcon> _houseIcons;

    public List<LanguageName> LanguageNames => _languageNames;
    public List<ExpansionName> AdditionNames => _additionNames;

    public string GetLanguageName(Language type)
    {
        return _languageNames.Find(x => x.Type == type).Name;
    }

    public string GetAdditionName(Expansions type)
    {
        return _additionNames.Find(x => x.Type == type).Name;
    }

    public Sprite GetHouseIcon(Houses Type)
    {
        return _houseIcons.Find(x => x.Type == Type).Icon;
    }

    public Sprite GetHouseIcon(string house)
    {
        Houses type;
        if(Enum.TryParse<Houses>(house, out type))
        {
            return GetHouseIcon(type);
        }

        return null;
    }
}

[Serializable]
public class LanguageName
{
    public Language Type;
    public string Name;
}

[Serializable]
public class ExpansionName
{
    public Expansions Type;
    public string Name;
}

[Serializable]
public class HouseIcon
{
    public Houses Type;
    public Sprite Icon;
}
