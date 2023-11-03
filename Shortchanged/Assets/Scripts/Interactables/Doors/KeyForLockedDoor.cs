using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyForLockedDoor : MonoBehaviour
{

    public GameObject thisLockedDoor;
    private LockedDoorOpen openScript;

    // Start is called before the first frame update
    void Start()
    {
        openScript = thisLockedDoor.GetComponent<LockedDoorOpen>();
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Player")
        {
            openScript.unlockDoor();
            Debug.Log("KeyCollected");
            Destroy(gameObject);
        }    
    }
}
