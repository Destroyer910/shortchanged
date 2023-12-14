using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackingKeyCode : MonoBehaviour
{
    public GameObject codeHack;
    public GameObject thisLockedDoor;
    public string keyGrabbedText;
    public string totalKeyCount;
    public string hackFailedText;
    private LockedDoorOpen openScript;
    private ShowText textScript;
    public bool ignoreNormalText;
    public int code1;
    public int code2;
    public int code3;
    public int code4;

    // Start is called before the first frame update
    void Start()
    {
        openScript = thisLockedDoor.GetComponent<LockedDoorOpen>();
        textScript = GameObject.Find("UiDisplay").GetComponent<ShowText>();
    }

    public void beginHack()
    {
        codeHack.GetComponent<PassCodeLock>().activateGame(gameObject, code1, code2, code3, code4);
    }

    public void disable(bool passed)
    {
        if(passed)
        {
            openScript.unlockDoor();
            
            if(ignoreNormalText)
            {
                textScript.updateText(keyGrabbedText);
            }
            else
            {
                textScript.updateText(keyGrabbedText + "| Hacks left: " + openScript.numOfKeys + "/" + totalKeyCount);
            }
            int newLayer = LayerMask.NameToLayer("CantInteract");
            gameObject.layer = newLayer;
        }
        else
        {
            textScript.updateText(hackFailedText);
        } 
    }
}
