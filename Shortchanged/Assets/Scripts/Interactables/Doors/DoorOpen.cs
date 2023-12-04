using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    
    private Transform childObject;
    private bool isOpen = false;
    public bool rotateCounterClockwise;
    public bool rotateUp;
    public bool rotateUpX;
    public bool deleteOnOpen;
    public float rotateAmount;

    void Start()
    {
        childObject = transform.Find("pivot");
    }

    public void toggleDoor()
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
    
}
