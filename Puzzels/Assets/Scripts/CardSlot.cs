using UnityEngine;

public class CardSlot : MonoBehaviour
{
    [SerializeField] private Transform _upgradesContainer;

    public void AddCard(Card card, bool taunt = false, bool opponent = false)
    {
        card.transform.SetParent(transform);
        if(taunt)
        {
            card.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 35 * (opponent ? -1 :1));
            _upgradesContainer.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 35 * (opponent ? -1 : 1));
        }
    }

    public void AddUpgrade(Card card)
    {
        card.transform.SetParent(_upgradesContainer);
    }
}
