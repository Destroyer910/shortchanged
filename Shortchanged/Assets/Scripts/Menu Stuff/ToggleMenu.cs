using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMenu : MonoBehaviour
{
    public GameObject menu;
    public bool keepTimeScale;

    public void toggleMenu()
    {
        if(menu.activeSelf)
        {
            menu.SetActive(false);
            if(!keepTimeScale)
            {
                Time.timeScale = 1;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
        else
        {
            menu.SetActive(true);
        }
    }
}
