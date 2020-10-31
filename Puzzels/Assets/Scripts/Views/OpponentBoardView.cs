using UnityEngine;

public class OpponentBoardView : BaseBoardView
{
    [SerializeField] private ContainerController _playedEffect;

    public Transform PlayedEffectsContainer => _playedEffect.Container;

    protected override void Clear()
    {
        base.Clear();
        _playedEffect.Clear();
    }
}
