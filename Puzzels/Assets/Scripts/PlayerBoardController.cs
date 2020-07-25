using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoardController : MonoBehaviour
{
    public Transform CreaturesLine;
    public Transform ArtefactLine;
    public KeysController Keys;

    public void SetKeysAndAmber(int forgedKeys, int amber)
    {
        Keys.SetKeys(forgedKeys, amber);
    }
}
