using UnityEngine;

public class PuzzelView : MonoBehaviour
{
    [SerializeField] private DescriptionView _descriptionView;
    [SerializeField] private PlayerBoardView _playerBoardView;
    [SerializeField] private OpponentBoardView _opponentBoardView;

    public void InitPlayerView(PlayerBoardData data, Sprite[] houses)
    {
        _playerBoardView.SetHouses(houses);
    }
}
