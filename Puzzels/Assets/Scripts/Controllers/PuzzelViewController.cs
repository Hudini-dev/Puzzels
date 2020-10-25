using Assets.Scripts.Data;
using System.Collections.Generic;
using UnityEngine;

public class PuzzelViewController : MonoBehaviour
{
    [SerializeField] private DescriptionView _descriptionView;
    [SerializeField] private PlayerBoardView _playerBoardView;
    [SerializeField] private OpponentBoardView _opponentBoardView;
    [SerializeField] private DataConfig _dataConfig;
    [SerializeField] private CardBuilder _cardBuilder;

    private Language _language;

    public void Init(PuzzelData data, Language language)
    {
        _language = language;

        _descriptionView.Init(data.DescriptionData);
        _playerBoardView.Init(data.PlayerData, GetPlayersHousesIcons(data.PlayerData.Houses));
        _opponentBoardView.Init(data.OponnentData, GetPlayersHousesIcons(data.OponnentData.Houses));

        LoadPlayerCards(data.PlayerData, _playerBoardView);
        LoadCards(data.OponnentData, _opponentBoardView);
    }

    private Sprite[] GetPlayersHousesIcons(string[] houses)
    {
        var icons = new Sprite[houses.Length];

        for (int i = 0; i < houses.Length; i++)
        {
            icons[i] = _dataConfig.GetHouseIcon(houses[i]);
        }

        return icons;
    }

    private void LoadCards(PlayerBoardData data, BaseBoardView view)
    {
        _cardBuilder.Init(data.Expansion, _language);
        SpawnCards(view.CreaturesContainer, data.PlayedCreatures);
        SpawnCards(view.ArtefactsContainer, data.PlayedArtifacts);
    }

    private void LoadPlayerCards(PlayerBoardData data, PlayerBoardView view)
    {
        LoadCards(data, view);
        SpawnCards(view.HandContainer, data.Hand);
    }

    private void SpawnCards(Transform holder, List<BaseCardData> cardDataList)
    {
        foreach (var cardData in cardDataList)
        {
            var slot = _cardBuilder.GetSlotCard(cardData);
            slot.transform.SetParent(holder, false);
            slot.transform.localScale = Vector3.one;
        }
    }

    private void SpawnCards(Transform holder, List<ArtifactCardData> cardDataList)
    {
        foreach (var cardData in cardDataList)
        {
            var slot = _cardBuilder.GetSlotCard(cardData);
            slot.transform.SetParent(holder, false);
            slot.transform.localScale = Vector3.one;
        }
    }

    private void SpawnCards(Transform holder, List<CreatureCardData> cardDataList, bool opponentSide = false)
    {
        foreach (var cardData in cardDataList)
        {
            var slot = _cardBuilder.GetSlotCard(cardData, opponentSide);
            slot.transform.SetParent(holder, false);
            slot.transform.localScale = Vector3.one;
        }
    }
}
