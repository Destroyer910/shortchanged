using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopUpText : MonoBehaviour
{
    public string textForPopUp;
    public GameObject menu;
    public TMP_Text textToDisplay;

    public void displayText()
    {
        menu.SetActive(true);
        textToDisplay.text = textForPopUp;
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
    }

}
