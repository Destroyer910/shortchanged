using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject : MonoBehaviour
{
    public GameObject colorHack;
    private ShowText textScript;

    void Start()
    {
        textScript = GameObject.Find("UiDisplay").GetComponent<ShowText>();
    }

    public void hackTest()
    {
        colorHack.GetComponent<PassCodeLock>().activateGame(gameObject);
    }

    public void disable(bool passed)
    {
        if(passed)
        {
            int newLayer = LayerMask.NameToLayer("CantInteract");
            gameObject.layer = newLayer;
            textScript.updateText("TestDisabled");
        }
        else
        {
            return;
        }
    }
}
