using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject : MonoBehaviour
{
    public GameObject colorHack;
    private ShowText textScript;
    public int code1;
    public int code2;
    public int code3;
    public int code4;

    void Start()
    {
        textScript = GameObject.Find("UiDisplay").GetComponent<ShowText>();
    }

    public void hackTest()
    {
        colorHack.GetComponent<PassCodeLock>().activateGame(gameObject, code1, code2, code3, code4);
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
