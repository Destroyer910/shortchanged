using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithStuff : MonoBehaviour
{

    public int raycastDistance = 10; 
    public int layer;

    void Start()
    {
        layer = LayerMask.GetMask("Interactable");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        RaycastHit hit;

        if (Physics.Raycast(transform.position, fwd, out hit, raycastDistance, layer))
        {
            if(hit.collider.tag == "Door")
            {
                
            }
        }

        Debug.DrawRay(transform.position, fwd * hit.distance, Color.yellow);

    }
}
