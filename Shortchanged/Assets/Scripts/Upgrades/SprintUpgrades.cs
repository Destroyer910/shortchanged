using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprintUpgrades : MonoBehaviour
{
    public PlayerManager playerManagerScript;
    public ShowText showTextScript;
    public string textForFailedBuy;
    public string textForBuy;
    public int cashCost;
    public float reqSpeed;
    public float newSpeed;
    public GameObject visualUpgrade;
    private bool isDeactivated = false;
    public Material deactivatedMaterial;
    public Material activatedMaterial;
    private Light theLight;
    private Vector3 startPosition;

    private void Start() 
    {
        theLight = visualUpgrade.GetComponent<Light>();  
        startPosition = transform.position;  
    }

    public void upgradeSprintSpeed()
    {   
        if(playerManagerScript.getPermCash() < cashCost)
        {
            showTextScript.updateText(textForFailedBuy);
        }
        else
        {
            playerManagerScript.setSprintSpeed(newSpeed);
            playerManagerScript.addPermCash(-cashCost);
            playerManagerScript.SavePlayerStuff();
            showTextScript.updateText(textForBuy);
        }
    }

    private void Update() 
    {
        if(playerManagerScript.getSprintSpeed() >= newSpeed && !isDeactivated)
        {
            disableButton();
        }
        if(playerManagerScript.getSprintSpeed() < reqSpeed)
        {
            disableButton();
        }
        else if(playerManagerScript.getSprintSpeed() == reqSpeed)
        {
            enableButton();
        }
    }

    private void disableButton()
    {
        visualUpgrade.GetComponent<MeshRenderer>().material = deactivatedMaterial;
        theLight.color = deactivatedMaterial.color;
        gameObject.transform.position = new Vector3(2000, 2000, 2000);
        isDeactivated = true;
    }

    private void enableButton()
    {
        visualUpgrade.GetComponent<MeshRenderer>().material = activatedMaterial;
        theLight.color = activatedMaterial.color;
        gameObject.transform.position = startPosition;
        isDeactivated = false;
    }

    

}
