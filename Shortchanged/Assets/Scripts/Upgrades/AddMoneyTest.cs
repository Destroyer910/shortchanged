using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMoneyTest : MonoBehaviour
{
    public PlayerManager playerManager;
    
    public void addMoneyTest()
    {
        playerManager.addPermCash(10000000);
        playerManager.SavePlayerStuff();
    }
}
