using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{      

    public float moveSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        //Get the mouse movement in the x direction for the y movement
        float rotationY = Input.GetAxis("Mouse X") * moveSpeed;
        float rotationX = Input.GetAxis("Mouse Y") * moveSpeed;

        rotationYAmount = 

        transform.rotation = Quaternion.Euler(rotationYAmount, 0, 0);
        transform.Rotate(0, rotationX, 0);
        
    }
}
