using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowBasedOnAmmoCount : MonoBehaviour
{   

    public PlayerMovement playerMovementScript;
    public GameObject ammo3;
    public GameObject ammo2;
    public GameObject ammo1;

    // Update is called once per frame
    void Update()
    {
        if(playerMovementScript.cameraDisableCountLocal == 3)
        {
            ammo3.SetActive(true);
            ammo2.SetActive(true);
            ammo1.SetActive(true);
        }
        else if(playerMovementScript.cameraDisableCountLocal == 2)
        {
            ammo3.SetActive(false);
            ammo2.SetActive(true);
            ammo1.SetActive(true);
        }
        else if(playerMovementScript.cameraDisableCountLocal == 1)
        {
            ammo3.SetActive(false);
            ammo2.SetActive(false);
            ammo1.SetActive(true);
        }
        else
        {
            ammo3.SetActive(false);
            ammo2.SetActive(false);
            ammo1.SetActive(false);
        }
    }
}
