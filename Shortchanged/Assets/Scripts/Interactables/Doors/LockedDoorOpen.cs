using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoorOpen : MonoBehaviour
{
     
    private GameObject parentObject;
    private float originalRotation;
    public float rotationSpeed;
    private bool unlocked = false;

    void Start()
    {
        parentObject = transform.parent.gameObject;
        originalRotation = transform.rotation.y;
    }

    public void toggleDoor()
    {
        if(unlocked)
        {
            Debug.Log("Start");
            if(transform.rotation.y == originalRotation)
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
            Debug.Log("DoorIsLocked");
        }
    }

    public void unlockDoor()
    {
        unlocked = true;
    }

}
