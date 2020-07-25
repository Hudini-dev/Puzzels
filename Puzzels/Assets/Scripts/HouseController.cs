using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HouseController : MonoBehaviour
{
    [SerializeField] private Image[] _houses;

    public void SetHouses(Sprite[] icons)
    {
        for (int i = 0; i < _houses.Length && i < icons.Length; i++)
        {
            _houses[i].sprite = icons[i];
        }
    }
}
