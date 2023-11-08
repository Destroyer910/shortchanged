using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColorPicker : MonoBehaviour
{

    private int color = 0;
    public TMP_Text colorText;
    public float delayTime = 4;
    public GameObject activator;
    public GameObject redButton;
    public GameObject blueButton;
    public GameObject greenButton;

    public void startMiniGame(GameObject activatorObject)
    {
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0;
        activator = activatorObject;
        color = Random.Range(0,3);
        redButton.SetActive(true);
        blueButton.SetActive(true);
        greenButton.SetActive(true);
        if(color == 0)
        {
            colorText.text = "Red";
        }
        else if(color == 1)
        {
            colorText.text = "Blue";
        }
        else if(color == 2)
        {
            colorText.text = "Green";
        }
    }

    public void answer(int colorNum)
    {
        if(colorNum == color)
        {
            StartCoroutine(correct());
        }
        else
        {
            StartCoroutine(wrong());
        }
    }

    private IEnumerator correct()
    {
        colorText.text = "Correct";
        redButton.SetActive(false);
        blueButton.SetActive(false);
        greenButton.SetActive(false);
        yield return new WaitForSecondsRealtime(delayTime);
        activator.GetComponent<DisableManager>().disableObject();
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }

    private IEnumerator wrong()
    {
        colorText.text = "Incorrect";
        redButton.SetActive(false);
        blueButton.SetActive(false);
        greenButton.SetActive(false);
        yield return new WaitForSecondsRealtime(delayTime);
        startMiniGame(activator);
    }
}
