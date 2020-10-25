using UnityEngine;

public class BaseBoardView : MonoBehaviour
{
    [SerializeField] private HousesView _housesView;
    [SerializeField] private KeysView _keyView;
    [SerializeField] private Transform _playedCreaturesContainer;
    [SerializeField] private Transform _playedArtefactsContainer;
    [SerializeField] private Transform _discardContainer;

    public Transform CreaturesContainer => _playedCreaturesContainer;
    public Transform ArtefactsContainer => _playedArtefactsContainer;
    public Transform DiscardContainer => _discardContainer;

    public virtual void Init(PlayerBoardData data, Sprite[] houseIcons)
    {
        Clear();
        SetHouses(houseIcons);
        SetKeys(data.ForgedKeys, data.Amber);
    }

    public void SetHouses(Sprite[] icons)
    {
        _housesView.Init(icons);
    }

    public void SetKeys(int forgetKeys, int amberCount)
    {
        _keyView.Init(forgetKeys, amberCount);
    }

    protected virtual void Clear()
    {
        foreach (Transform child in _playedCreaturesContainer)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in _playedArtefactsContainer)
        {
            Destroy(child.gameObject);
        }
    }
}
