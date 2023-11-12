using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyForLockedDoor : MonoBehaviour
{

    public GameObject thisLockedDoor;
    private LockedDoorOpen openScript;
    private ShowText textScript;

    // Start is called before the first frame update
    void Start()
    {
        openScript = thisLockedDoor.GetComponent<LockedDoorOpen>();
        textScript = GameObject.Find("UiDisplay").GetComponent<ShowText>();
    }

    public void collectKey()
    {
        openScript.unlockDoor();
        Debug.Log("KeyCollected");
        textScript.updateText("Key collected");
        Destroy(gameObject);
    }
}
