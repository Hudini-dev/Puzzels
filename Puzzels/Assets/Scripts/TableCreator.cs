using Assets.Scripts;
using System.Collections.Generic;
using UnityEngine;

public class TableCreator : MonoBehaviour
{
    [SerializeField] private PlayerTableData _playerData;
    [SerializeField] private PlayerTableData _opponentData;
    [SerializeField] private CardBuilder _cardBuilder;

    [SerializeField] private HandView _playerHand;
    [SerializeField] private PlayerBoardController _player;

    [SerializeField] private HandView _opponentHand;
    [SerializeField] private PlayerBoardController _opponent;

    [SerializeField] private ContainerController _playedEffectsContainer;
    [SerializeField] private ContainerController _archiveContainer;

    void Start()
    {
        SpawCards(_playerHand.HandLinie, _playerData.Hand);
        SpawCards(_player.ArtefactLine, _playerData.PlayedArtifacts);
        SpawCards(_player.CreaturesLine, _playerData.PlayedCreatures);
        SpawCards(_opponent.ArtefactLine, _opponentData.PlayedArtifacts);
        SpawCards(_opponent.CreaturesLine, _opponentData.PlayedCreatures, true);
        SpawCards(_archiveContainer.Container, _playerData.Archive);

        _opponentHand.SetHouses(_opponentData.Houses);
        _playerHand.SetHouses(_playerData.Houses);

        SetKeys(_opponent.Keys, _opponentData.ForgedKeys, _opponentData.Amber);
        SetKeys(_player.Keys, _playerData.ForgedKeys, _playerData.Amber);

    }
    
    private void SpawCards(Transform holder, List<CardData> cardDataList)
    {
        foreach (var cardData in cardDataList)
        {
            var slot = _cardBuilder.GetSlotCard(cardData);
            slot.transform.SetParent(holder, false);
            slot.transform.localScale = Vector3.one;
        }
    }

    private void SpawCards(Transform holder, List<CreatureCardData> cardDataList, bool opponentSide = false)
    {
        foreach (var cardData in cardDataList)
        {
            var slot = _cardBuilder.GetSlotCard(cardData, opponentSide);
            slot.transform.SetParent(holder, false);
            slot.transform.localScale = Vector3.one;
        }
    }

    private void SetHouses(HouseController houses, Sprite[] icons)
    {
        houses.SetHouses(icons);
    }

    private void SetKeys(KeysController keys, int keysCount, int amberCount)
    {
        keys.SetKeys(keysCount, amberCount);
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.S))
        {
            TakeScreenShot();
        }
    }

    private void TakeScreenShot()
    {
        ScreenCapture.CaptureScreenshot("TABLE_SCREEN");
    }
}
