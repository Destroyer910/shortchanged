using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestResetValues : MonoBehaviour
{
    public PlayerManager playerManager;
    
    public void resetValues()
    {
        playerManager.setJumpHeight(10f);
        playerManager.setSpeed(5f);
        playerManager.setSprintSpeed(9f);
        playerManager.setDetectionSpeed(3.0f);
        playerManager.setPermCash(0);
        playerManager.setMaxDetection(75);
        playerManager.setUnlockedLevel2(false);
        playerManager.SavePlayerStuff();
    }
}
