using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractWithStuff : MonoBehaviour
{

    public int raycastDistance = 10; 
    public int layer;
    public Sprite cantDoReticle;
    public Sprite canDoReticle;
    public Image reticle;

    void Start()
    {
        layer = LayerMask.GetMask("Interactable");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        RaycastHit hit;
        
        Debug.DrawRay(transform.position, fwd * raycastDistance, Color.yellow);

        if (Physics.Raycast(transform.position, fwd, out hit, raycastDistance, layer))
        {
            reticle.sprite = canDoReticle;
            if(hit.collider.tag == "Door")
            {
                if(Input.GetKeyDown(KeyCode.E))
                {
                    DoorOpen doorScript = hit.collider.gameObject.GetComponent<DoorOpen>();
                    doorScript.toggleDoor();
                }
            }
            else if(hit.collider.tag == "LockedDoor")
            {
                if(Input.GetKeyDown(KeyCode.E))
                {
                    LockedDoorOpen doorScript = hit.collider.gameObject.GetComponent<LockedDoorOpen>();
                    doorScript.toggleDoor();
                }
            }
        }
        else
        {
            reticle.sprite = cantDoReticle;
        }

    }
}
