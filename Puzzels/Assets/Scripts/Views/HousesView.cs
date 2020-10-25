using UnityEngine;
using UnityEngine.UI;

public class HousesView : MonoBehaviour
{
    [SerializeField] private Image[] _houses;

    public void Init(Sprite[] icons)
    {
        for (int i = 0; i < _houses.Length && i < icons.Length; i++)
        {
            _houses[i].sprite = icons[i];
        }
    }
}
