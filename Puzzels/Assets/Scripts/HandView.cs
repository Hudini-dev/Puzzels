using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandView : MonoBehaviour
{
    [SerializeField] private Transform _handLine;
    [SerializeField] private HouseController _houseController;

    public Transform HandLinie => _handLine;

    public void SetHouses(Sprite[] icons)
    {
        _houseController.SetHouses(icons);
    }
}
