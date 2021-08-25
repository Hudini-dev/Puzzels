
using Assets.Scripts;
using Assets.Scripts.Data.Builder;
using UnityEngine;

public class CardBuilder : MonoBehaviour
{
    [SerializeField] private Card _cardPrefab;
    [SerializeField] private Token _markerPrefab;
    [SerializeField] private CardSlot _cardSlotPrefab;
    [SerializeField] private ArchonCardController _archonCardPrefab;
    [SerializeField] private Sprite _amberMarker;
    [SerializeField] private Sprite _damageMarker;
    [SerializeField] private Sprite _stunMarker;
    [SerializeField] private Sprite _wardMarker;
    [SerializeField] private Sprite _enrageMarker;
    [SerializeField] private Sprite _powerMarker;
    [SerializeField] private CardsLoader _cardLoader;
    [SerializeField] private Sprite[] _enhancementBackgrounds;
    [SerializeField] private Sprite _amberPip;
    [SerializeField] private Sprite _capturePip;
    [SerializeField] private Sprite _damagePip;
    [SerializeField] private Sprite _drawPip;

    public void Init(Expansions expansion, Language language)
    {
        _cardLoader.Init(expansion, language);
    }

    public CardSlot GetSlotCard(CardData data)
    {
        var slot = Instantiate(_cardSlotPrefab);
        var card = GetCard(data);
        slot.AddCard(card);
        return slot;
    }

    public CardSlot GetSlotCard(BaseCardData data)
    {
        var slot = Instantiate(_cardSlotPrefab);
        var card = GetCard(data);
        slot.AddCard(card);
        return slot;
    }

    public CardSlot GetSlotCard(Assets.Scripts.Data.CreatureCardData data, bool opponentSide = false)
    {
        var slot = Instantiate(_cardSlotPrefab);
        var card = GetCard(data);
        slot.AddCard(card, data.Taunt, opponentSide);
        foreach(var upg in data.Upgrades)
        {
            slot.AddUpgrade(GetCard(upg));
        }
        if (data.CardUnder)
        {
            var archonCard = Instantiate(_archonCardPrefab);
            archonCard.transform.SetParent(slot.transform);
            archonCard.transform.SetAsFirstSibling();
            archonCard.transform.position = new Vector3(0, -40, 0);
        }
        return slot;
    }

    public CardSlot GetSlotCard(Assets.Scripts.Data.Builder.CreatureCardData data, bool opponentSide = false)
    {
        var slot = Instantiate(_cardSlotPrefab);
        var card = GetCard(data);
        slot.AddCard(card, data.Taunt, opponentSide);
        foreach (var upg in data.Upgrades)
        {
            slot.AddUpgrade(GetCard(upg));
        }
        if (data.CardUnder)
        {
            var archonCard = Instantiate(_archonCardPrefab);
            archonCard.transform.SetParent(slot.transform);
            archonCard.transform.SetAsFirstSibling();
            archonCard.transform.position = new Vector3(0, -40, 0);
        }
        return slot;
    }

    public Card GetCard(CardData data)
    {
        var card = Instantiate(_cardPrefab);
        card.SetFront(data.Front);
        return card;
    }

    public Card GetCard(BaseCardData data)
    {
        var card = Instantiate(_cardPrefab);
        var front = _cardLoader.GetCard(data.Id);
        card.SetFront(front);
        return card;
    }

    public Card GetCard(Assets.Scripts.Data.CreatureCardData data)
    {
        var card = Instantiate(_cardPrefab);
        var front = _cardLoader.GetCard(data.Id);
        card.SetFront(front);

        if(data.Amber > 0)
        {
            card.AddMarker(CreateMarker( _amberMarker, data.Amber));
        }

        if (data.Damage > 0)
        {
            card.AddMarker(CreateMarker(_damageMarker, data.Damage));
        }

        if (data.Stun)
        {
            card.AddMarker(CreateMarker(_stunMarker));
        }

        if (data.Ward)
        {
            card.AddMarker(CreateMarker( _wardMarker));
        }

        if (data.Enrage)
        {
            card.AddMarker(CreateMarker(_enrageMarker));
        }

        if (data.Power > 0)
        {
            card.AddMarker(CreateMarker(_powerMarker, data.Power));
        }

        return card;
    }

    private Transform CreateMarker( Sprite icon, int counter = 0)
    {
        var marker = Instantiate(_markerPrefab);
        marker.Init(icon, counter);
        return marker.transform;
    }
}
