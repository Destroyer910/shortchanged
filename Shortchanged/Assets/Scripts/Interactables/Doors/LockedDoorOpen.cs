using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoorOpen : MonoBehaviour
{
     
    private Transform childObject;
    private bool unlocked = false;
    private bool isOpen = false;
    private ShowText textScript;
    public bool rotateCounterClockwise;
    public bool rotateUp;
    public bool rotateUpX;
    public bool deleteOnOpen;
    public bool deleteOnUnlock;
    public bool openOnlyOnUnlock;
    public float rotateAmount;
    public float numOfKeys;
    public string textForFail;
    public string textToReplaceFailAfterOpenOnUnlock;
    

    void Start()
    {
        childObject = transform.Find("pivot");
        textScript = GameObject.Find("UiDisplay").GetComponent<ShowText>();
    }

    public void toggleDoor()
    {
        if(unlocked)
        {
            if(deleteOnOpen)
            {
                Destroy(gameObject);
            }
            if(!rotateCounterClockwise)
            {
                if(rotateUpX)
                {
                    if(!isOpen)
                    {
                        transform.RotateAround(childObject.position, transform.right, rotateAmount);
                        isOpen = true;
                    }
                    else
                    {
                        transform.RotateAround(childObject.position, transform.right, -rotateAmount);
                        isOpen = false;
                    }
                }
                else if(rotateUp)
                {
                    if(!isOpen)
                    {
                        transform.RotateAround(childObject.position, transform.forward, rotateAmount);
                        isOpen = true;
                    }
                    else
                    {
                        transform.RotateAround(childObject.position, transform.forward, -rotateAmount);
                        isOpen = false;
                    }
                }
                else
                {
                    if(!isOpen)
                    {
                        transform.RotateAround(childObject.position, Vector3.up, rotateAmount);
                        isOpen = true;
                    }
                    else
                    {
                        transform.RotateAround(childObject.position, Vector3.up, -rotateAmount);
                        isOpen = false;
                    }
                }
            }
            else
            {
                if(rotateUpX)
                {
                    if(!isOpen)
                    {
                        transform.RotateAround(childObject.position, transform.right, -rotateAmount);
                        isOpen = true;
                    }
                    else
                    {
                        transform.RotateAround(childObject.position, transform.right, rotateAmount);
                        isOpen = false;
                    }
                }
                else if(rotateUp)
                {
                    if(!isOpen)
                    {
                        transform.RotateAround(childObject.position, transform.forward, -rotateAmount);
                        isOpen = true;
                    }
                    else
                    {
                        transform.RotateAround(childObject.position, transform.forward, rotateAmount);
                        isOpen = false;
                    }
                }
                else
                {
                    if(!isOpen)
                    {
                        transform.RotateAround(childObject.position, Vector3.up, -rotateAmount);
                        isOpen = true;
                    }
                    else
                    {
                        transform.RotateAround(childObject.position, Vector3.up, rotateAmount);
                        isOpen = false;
                    }
                }
            }
        }
        else
        {
            textScript.updateText(textForFail);
        }
    }

    public void unlockDoor()
    {
        if(numOfKeys > 0)
        {
            numOfKeys--;
        }
        if(numOfKeys == 0)
        {
            if(deleteOnUnlock)
            {
                Destroy(gameObject);
            }
            else if(openOnlyOnUnlock)
            {
                unlocked = true;
                toggleDoor();
                unlocked = false;
                textForFail = textToReplaceFailAfterOpenOnUnlock;
            }
            else
            {
                unlocked = true;
            }
        }
    }

}
