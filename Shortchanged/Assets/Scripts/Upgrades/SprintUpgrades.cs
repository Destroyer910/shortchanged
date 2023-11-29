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
    public float newSpeed;
    public GameObject visualUpgrade;
    private bool isDeactivated = false;
    public Material deactivatedMaterial;
    private Light theLight;

    private void Start() 
    {
        theLight = visualUpgrade.GetComponent<Light>();    
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
            visualUpgrade.GetComponent<MeshRenderer>().material = deactivatedMaterial;
            theLight.color = Color.gray;
            gameObject.transform.position = new Vector3(2000, 2000, 2000);
            isDeactivated = true;
        }
    }

    

}
