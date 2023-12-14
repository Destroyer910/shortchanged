using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionSpeedUpgrade : MonoBehaviour
{
    public PlayerManager playerManagerScript;
    public ShowText showTextScript;
    public string textForFailedBuy;
    public string textForBuy;
    public int cashCost;
    //Change name per upgrade
    public float reqDetSpeed;
    //Change name per upgrade
    public float newDetSpeed;
    public GameObject visualUpgrade;
    private bool isDeactivated = false;
    public Material deactivatedMaterial;
    public Material activatedMaterial;
    private Light theLight;
    private Vector3 startPosition;
    private bool isBought = false;
    public GameObject boughtText;
    public GameObject lockedText;

    private void Start() 
    {
        theLight = visualUpgrade.GetComponent<Light>();  
        startPosition = transform.position;  
    }

    //Change nethod name.
    public void upgradeDetectionSpeed()
    {   
        if(playerManagerScript.getPermCash() < cashCost)
        {
            showTextScript.updateText(textForFailedBuy);
        }
        else
        {
            //Change value per script
            playerManagerScript.setDetectionSpeed(newDetSpeed);
            playerManagerScript.addPermCash(-cashCost);
            playerManagerScript.SavePlayerStuff();
            showTextScript.updateText(textForBuy);
        }
    }

    private void Update() 
    {
        //Change check per script
        if(playerManagerScript.getDetectionSpeed() <= newDetSpeed && !isDeactivated)
        {
            disableButton();
            isBought = true;
        }
        //Change check per script
        if(playerManagerScript.getDetectionSpeed() > reqDetSpeed && !isDeactivated)
        {
            disableButton();
            isBought = false;
        }
        //Change check per script
        else if(playerManagerScript.getDetectionSpeed() == reqDetSpeed && isDeactivated)
        {
            enableButton();
        }
        if(isBought && isDeactivated)
        {
            boughtText.SetActive(true);
            lockedText.SetActive(false);
        }
        else if(!isBought && isDeactivated)
        {
            lockedText.SetActive(true);
            boughtText.SetActive(false);
        }
        else
        {
            lockedText.SetActive(false);
            boughtText.SetActive(false);
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
        boughtText.SetActive(false);
        lockedText.SetActive(false);
    }
    
    private void OnEnable() 
    {
        if(isBought && isDeactivated)
        {
            boughtText.SetActive(true);
            lockedText.SetActive(false);
        }
        else if(!isBought && isDeactivated)
        {
            lockedText.SetActive(true);
            boughtText.SetActive(false);
        }
        else
        {
            lockedText.SetActive(false);
            boughtText.SetActive(false);
        }
    }
}
