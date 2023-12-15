using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabAmmo : MonoBehaviour
{

    private ShowText showTextScript;
    private PlayerMovement playerMovementScript;
    public string textToShowWhenFull;
    public string textToShowWhenGrabbed;

    // Start is called before the first frame update
    void Start()
    {
        showTextScript = GameObject.Find("UiDisplay").GetComponent<ShowText>();
        playerMovementScript = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    public void grabAmmo()
    {
        if(playerMovementScript.cameraDisableCountLocal == 3)
        {
            showTextScript.updateText(textToShowWhenFull);
        }
        else
        {
            playerMovementScript.cameraDisableCountLocal++;
            showTextScript.updateText(textToShowWhenGrabbed);
            Destroy(gameObject);
        }
    }
}
