using UnityEngine;
using UnityEngine.UI;

public class CardContextMenuController : MonoBehaviour
{
    [SerializeField] private Toggle _readyToggle;
    [SerializeField] private Button _addAmberButton;
    [SerializeField] private Button _addDamageButton;
    [SerializeField] private Toggle _wardToggle;
    [SerializeField] private Toggle _enrageToggle;
    [SerializeField] private Toggle _stunToggle;

    private void foo()
    {
        CardType cardType = CardType.ACTION;
        switch (cardType)
        {
            case CardType.CREATURE:
                break;
            case CardType.ARTIFACT:
                break;
            case CardType.UPGRADE:
                break;
            case CardType.ACTION:
            default:
                break;
        }
    }

}
