using UnityEngine;

public class PlayerBoardView : BaseBoardView
{
    [SerializeField] private Transform _handContainer;
    [SerializeField] private Transform _archiveContainer;
    [SerializeField] private Transform _deckContainer;

    public Transform HandContainer => _handContainer;
    public Transform ArchiveContainer => _archiveContainer;
    public Transform DeckContainer => _deckContainer;

    protected override void Clear()
    {
        base.Clear();
        foreach (Transform child in _handContainer)
        {
            Destroy(child.gameObject);
        }
    }
}
