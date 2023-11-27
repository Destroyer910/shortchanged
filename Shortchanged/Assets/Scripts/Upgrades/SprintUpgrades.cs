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
}
