using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithStuff : MonoBehaviour
{

    public int raycastDistance = 10; 

    // Update is called once per frame
    void Update()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, raycastDistance))
        {

        }
            
    }
}
