using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackingKeyColor : MonoBehaviour
{
    public GameObject colorHack;
    public GameObject thisLockedDoor;
    public string keyGrabbedText;
    public string totalKeyCount;
    public string hackFailedText;
    private LockedDoorOpen openScript;
    private ShowText textScript;
    public bool ignoreNormalText;

    // Start is called before the first frame update
    void Start()
    {
        openScript = thisLockedDoor.GetComponent<LockedDoorOpen>();
        textScript = GameObject.Find("UiDisplay").GetComponent<ShowText>();
    }

    public void beginHack()
    {
        colorHack.SetActive(true);
        colorHack.GetComponent<ColorPicker>().startMiniGame(gameObject);
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
