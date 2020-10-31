using UnityEngine;

public class PlayerBoardView : BaseBoardView
{
    [SerializeField] private Transform _handContainer;
    [SerializeField] private ContainerController _archive;
    [SerializeField] private ContainerController _deck;

    public Transform HandContainer => _handContainer;
    public Transform ArchiveContainer => _archive.Container;
    public Transform DeckContainer => _deck.Container;

    protected override void Clear()
    {
        base.Clear();
        foreach (Transform child in _handContainer)
        {
            Destroy(child.gameObject);
        }

        _archive.Clear();
        _deck.Clear();
    }
}
