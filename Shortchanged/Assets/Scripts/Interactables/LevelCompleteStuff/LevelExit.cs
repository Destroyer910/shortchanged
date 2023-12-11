using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelExit : MonoBehaviour
{

    private GameObject player;
    private GameObject otherMenuStuff;
    public GameObject thisMenu;
    private PlayerManager playerManager;
    public bool isLevel1;

    void Start()
    {
        player = GameObject.Find("Player");
        otherMenuStuff = GameObject.Find("AllOtherMenuStuff");
        playerManager = GameObject.Find("PlayerManager").GetComponent<PlayerManager>();
    }

    public void completeLevel()
    {
        player.GetComponent<PlayerMovement>().enabled = false;
        otherMenuStuff.SetActive(false);
        thisMenu.SetActive(true);
        playerManager.addPermCash(playerManager.getLevelCash());
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        if(isLevel1)
        {
            playerManager.setUnlockedLevel2(true);
        }
        playerManager.SavePlayerStuff();
    }
}
