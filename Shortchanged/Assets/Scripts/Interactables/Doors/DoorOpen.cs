using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    
    private GameObject parentObject;
    public float originalRotation;
    public float rotationSpeed;

    void Start()
    {
        parentObject = transform.parent.gameObject;
        originalRotation = transform.eulerAngles.y;
    }

    public void toggleDoor()
    {
        Debug.Log(parentObject.transform.rotation.y);
        Debug.Log(originalRotation);
        Debug.Log("Start");
        if(transform.eulerAngles.y == originalRotation)
        {
            parentObject.transform.localEulerAngles = new Vector3(0, originalRotation + 90, 0);
        }
        else
        {
            parentObject.transform.localEulerAngles = new Vector3(0, originalRotation, 0);
        }
        Debug.Log(parentObject.transform.rotation.y);
    }
    
}
