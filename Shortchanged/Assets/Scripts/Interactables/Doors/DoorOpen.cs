using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    
    private GameObject parentObject;
    private float originalRotation;
    public float rotationSpeed;

    void Start()
    {
        parentObject = transform.parent.gameObject;
        originalRotation = transform.rotation.y;
    }

    public void toggleDoor()
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
    
}
