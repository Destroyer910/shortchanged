using System.Collections.Specialized;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.VisualScripting;

public class InteractWithStuff : MonoBehaviour
{

    public int raycastDistance = 10; 
    public int layer = 6;
    public Sprite cantDoReticle;
    public Sprite canDoReticle;
    public Image reticle;
    private RaycastHit hit;
    private Vector3 fwd;

    void Update() {
        if (Physics.Raycast(transform.position, fwd, out hit, raycastDistance))
        {
            if(hit.collider.gameObject.layer == layer)
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
                //If the player is looking at a move open object.
                else if(hit.collider.tag == "MoveOpen")
                {
                    if(Input.GetKeyDown(KeyCode.E))
                    {
                        MoveForwardOpen moveOpenScript = hit.collider.gameObject.GetComponent<MoveForwardOpen>();
                        moveOpenScript.toggleOpen();
                    }
                }
                //If the player is looking at a test disable object.
                else if(hit.collider.tag == "TestDisable")
                {
                    if(Input.GetKeyDown(KeyCode.E))
                    {
                        //Run the hacking minigame.
                        TestObject testObjectScript = hit.collider.gameObject.GetComponent<TestObject>();
                        testObjectScript.hackTest();
                    }
                }
                else if(hit.collider.tag == "Stealable")
                {
                    if(Input.GetKeyDown(KeyCode.E))
                    {
                        // Steal the thing
                        Stealables stealables = hit.collider.gameObject.GetComponent<Stealables>();
                        stealables.stealItem(this.transform.parent.GameObject().GetComponent<PlayerManager>());
                    }
                }
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Grab the forward direction of the camera.
        fwd = transform.TransformDirection(Vector3.forward);
        
        //Draw the ray for debug purposes!
        Debug.DrawRay(transform.position, fwd * raycastDistance, Color.yellow);

        //If the ray hits an interactable object withing the distance provided.
        if (Physics.Raycast(transform.position, fwd, out hit, raycastDistance))
        {
            if(hit.collider.gameObject.layer == layer)
            {
                //Set the reticle to be when it can interact with stuff.
                reticle.sprite = canDoReticle;
            }
            else
            {
                //Otherwise set the reticle to be not looking at an interactable object.
                reticle.sprite = cantDoReticle;
            }
        }
        else
        {
            //Otherwise set the reticle to be not looking at an interactable object.
            reticle.sprite = cantDoReticle;
        }

    }
}
