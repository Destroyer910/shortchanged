using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoorOpen : MonoBehaviour
{
     
    private GameObject parentObject;
    public float originalRotation;
    public float rotationSpeed;
    private bool unlocked = false;
    private ShowText textScript;

    void Start()
    {
        parentObject = transform.parent.gameObject;
        originalRotation = parentObject.transform.eulerAngles.y;
        textScript = GameObject.Find("UiDisplay").GetComponent<ShowText>();
    }

    public void toggleDoor()
    {
        if(unlocked)
        {
            Debug.Log("Start");
            if(transform.eulerAngles.y == originalRotation)
            {
                parentObject.transform.localEulerAngles = new Vector3(0, originalRotation + 90, 0);
            }
            else
            {
                parentObject.transform.localEulerAngles = new Vector3(0, originalRotation, 0);
            }
        }
        else
        {
            textScript.updateText("Door is locked");
        }
    }

    public void unlockDoor()
    {
        unlocked = true;
    }

}
