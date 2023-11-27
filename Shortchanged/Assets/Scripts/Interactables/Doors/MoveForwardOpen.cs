using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardOpen : MonoBehaviour
{
    private Transform childObject;
    private Vector3 originalPosition;
    private bool isOpen = false;
    public bool deleteOnOpen;

    // Start is called before the first frame update
    void Start()
    {
        childObject = transform.Find("openPoint");
        originalPosition = transform.position;
    }

    public void toggleOpen()
    {
        if(deleteOnOpen)
        {
            Destroy(gameObject);
        }
        if(!isOpen)
        {
            transform.position = childObject.position; 
            isOpen = true;      
        }
        else
        {
            transform.position = originalPosition;
            isOpen = false;
        }
    }
}
