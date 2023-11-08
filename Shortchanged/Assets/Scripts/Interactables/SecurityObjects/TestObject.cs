using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject : MonoBehaviour
{
    public GameObject colorHack;

    public void hackTest()
    {
        colorHack.SetActive(true);
        colorHack.GetComponent<ColorPicker>().startMiniGame(gameObject);
    }

    public void disable()
    {
        int newLayer = LayerMask.NameToLayer("CantInteract");
        gameObject.layer = newLayer;
    }
}
