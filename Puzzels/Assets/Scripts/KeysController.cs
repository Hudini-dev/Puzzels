﻿using UnityEngine;

public class KeysController : MonoBehaviour
{
    [SerializeField] private KeyView[] _keys;

    public void SetKeys(int forgetKeys, int amberCount)
    {
        for(int i = 0; i < forgetKeys && i < _keys.Length; i++)
        {
            _keys[i].ForgeKey();
        }

        if(forgetKeys < _keys.Length && amberCount > 0)
        {
            _keys[forgetKeys].SetAmber(amberCount);
        }
    }
    

}
