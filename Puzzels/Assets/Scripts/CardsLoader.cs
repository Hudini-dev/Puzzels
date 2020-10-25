using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CardsLoader : MonoBehaviour
{
    private const string MAIN_CARDS_FOLDER = "Cards";

    [SerializeField] private DataConfig _dataConfig;

    private Language _language;
    private Expansions _expansion;

    private Dictionary<string, Sprite> _cardsMap = new Dictionary<string, Sprite>();

    public void Init(Expansions expansion, Language language)
    {
        if(_expansion == expansion && _language == language && _cardsMap.Count > 0)
        {
            return;
        }

        _expansion = expansion;
        _language = language;
        LoadCards();
    }

    private void LoadCards()
    {
        _cardsMap.Clear();

        var expansion = _dataConfig.GetAdditionName(_expansion);
        var language = _dataConfig.GetLanguageName(_language);
        var p = Path.Combine(MAIN_CARDS_FOLDER, expansion, language);
        var sprites = Resources.LoadAll(p, typeof(Sprite));

        foreach (var s in sprites)
        {
            var id = s.name.Split('_')[0];
            _cardsMap.Add(id, s as Sprite);
        }
    }

    public Sprite GetCard(string id)
    {
        if(_cardsMap.ContainsKey(id))
        {
            return _cardsMap[id];
        }

        Debug.LogError("Not found card with ID: " + id);
        return null;
    }
}
