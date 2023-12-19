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
                //If the player is looking at a pop up text object.
                else if(hit.collider.tag == "PopUp")
                {
                    if(Input.GetKeyDown(KeyCode.E))
                    {
                        //Pop up the pop up.
                        PopUpText popUpTextScript = hit.collider.gameObject.GetComponent<PopUpText>();
                        popUpTextScript.displayText();
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
                //If the player is looking at the exit.
                else if(hit.collider.tag == "Exit")
                {
                    if(Input.GetKeyDown(KeyCode.E))
                    {
                        //CompleteTheLevel.
                        LevelExit levelExitScript = hit.collider.gameObject.GetComponent<LevelExit>();
                        levelExitScript.completeLevel();
                    }
                }
                //If the player is looking at a color hacking minigame key.
                else if(hit.collider.tag == "ColorHack")
                {
                    if(Input.GetKeyDown(KeyCode.E))
                    {
                        //Start the minigame.
                        HackingKeyColor hackingColorScript = hit.collider.gameObject.GetComponent<HackingKeyColor>();
                        hackingColorScript.beginHack();
                    }
                }
                //If the player is looking at a code hacking minigame key.
                else if(hit.collider.tag == "CodeHack")
                {
                    if(Input.GetKeyDown(KeyCode.E))
                    {
                        //Start the minigame
                        HackingKeyCode hackingCodeScript = hit.collider.gameObject.GetComponent<HackingKeyCode>();
                        hackingCodeScript.beginHack();
                    }
                }
                //If the player is looking at a simon says minigame key.
                else if(hit.collider.tag == "SimonSays")
                {
                    if(Input.GetKeyDown(KeyCode.E))
                    {
                        //Start the minigame.
                        HackingKeySimonSays hackingSimonSaysScript = hit.collider.gameObject.GetComponent<HackingKeySimonSays>();
                        hackingSimonSaysScript.beginHack();
                    }
                }
                //If the player is looking at a camera disable refil.
                else if(hit.collider.tag == "AmmoRefil")
                {
                    if(Input.GetKeyDown(KeyCode.E))
                    {
                        //Grab the camera disable refil
                        GrabAmmo grabAmmoScript = hit.collider.gameObject.GetComponent<GrabAmmo>();
                        grabAmmoScript.grabAmmo();
                    }
                }
                else if(hit.collider.tag == "Painting")
                {
                    if(Input.GetKeyDown(KeyCode.E))
                    {
                        PaintingScript painting = hit.collider.gameObject.GetComponent<PaintingScript>();
                        painting.makeNoise();
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
