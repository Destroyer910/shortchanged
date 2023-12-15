using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackingKeySimonSays : MonoBehaviour
{
    public GameObject simonSaysHack;
    public GameObject thisLockedDoor;
    public string keyGrabbedText;
    public string totalKeyCount;
    public string hackFailedText;
    private LockedDoorOpen openScript;
    private ShowText textScript;
    public bool ignoreNormalText;
    public int[] colorAnswers;

    // Start is called before the first frame update
    void Start()
    {
        openScript = thisLockedDoor.GetComponent<LockedDoorOpen>();
        textScript = GameObject.Find("UiDisplay").GetComponent<ShowText>();
    }

    public void beginHack()
    {
        simonSaysHack.SetActive(true);
        simonSaysHack.GetComponent<SimonSaysPredetermined>().StartSimonSays(gameObject, colorAnswers);
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
