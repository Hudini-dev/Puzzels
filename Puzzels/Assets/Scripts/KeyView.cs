using Assets.Scripts;
using UnityEngine;
using UnityEngine.UI;

public class KeyView : MonoBehaviour
{
    [SerializeField] private Image _keyImage;
    [SerializeField] private Sprite _forgedKey;
    [SerializeField] private Marker _amberMarker;
    [SerializeField] private Sprite _amberSprite;

    private void Awake()
    {
        _amberMarker.gameObject.SetActive(false);
    }

    public void ForgeKey()
    {
        _keyImage.sprite = _forgedKey;
    }

    public void SetAmber(int value)
    {
        _amberMarker.Init(_amberSprite, value);
        _amberMarker.gameObject.SetActive(true);
    }
}
