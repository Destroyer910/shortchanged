using System.Collections.Specialized;
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
        //Set the layer to check the raycast to the interactable layer.
        layer = LayerMask.GetMask("Interactable");
    }

    // Update is called once per frame
    void Update()
    {
        //Grab the forward direction of the camera.
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        
        //The output variable for the raycast.
        RaycastHit hit;
        
        //Draw the ray for debug purposes!
        Debug.DrawRay(transform.position, fwd * raycastDistance, Color.yellow);

        //If the ray hits an interactable object withing the distance provided.
        if (Physics.Raycast(transform.position, fwd, out hit, raycastDistance, layer))
        {
            //Set the reticle to be when it can interact with stuff.
            reticle.sprite = canDoReticle;

            //If the player is looking at a door.
            if(hit.collider.tag == "Door")
            {
                if(Input.GetKeyDown(KeyCode.E))
                {
                    //Grab the door's script and run a method.
                    DoorOpen doorScript = hit.collider.gameObject.GetComponent<DoorOpen>();
                    doorScript.toggleDoor();
                }
            }
            //If the player is looking at a lockableDoor.
            else if(hit.collider.tag == "LockedDoor")
            {
                if(Input.GetKeyDown(KeyCode.E))
                {
                    //Grab the locked door script and try to pen it.
                    LockedDoorOpen doorScript = hit.collider.gameObject.GetComponent<LockedDoorOpen>();
                    doorScript.toggleDoor();
                }
            }
            //If the player is looking at a key to a locked door.
            else if(hit.collider.tag == "Key")
            {
                if(Input.GetKeyDown(KeyCode.E))
                {
                    //Grab the key script and collect the key.
                    KeyForLockedDoor keyScript = hit.collider.gameObject.GetComponent<KeyForLockedDoor>();
                    keyScript.collectKey();
                }
            }
        }
        else
        {
            //Otherwise set the reticle to be not looking at an interactable object.
            reticle.sprite = cantDoReticle;
        }

    }
}
