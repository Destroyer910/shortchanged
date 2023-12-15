using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SimonSaysPredetermined : MonoBehaviour
{
    private int[] colorsInOrder;
    private int colorsIndex = 0;
    public TMP_Text failWinText;
    private GameObject activator;
    public GameObject redButton;
    public GameObject blueButton;
    public GameObject greenButton;
    public GameObject yellowButton;
    public float delayTime = 3f;

    public void StartSimonSays(GameObject activatorObject, int[] newAnswers)
    {
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0;
        colorsInOrder = newAnswers;
        activator = activatorObject;
        redButton.SetActive(true);
        blueButton.SetActive(true);
        greenButton.SetActive(true);
        yellowButton.SetActive(true);
    }

    public void nextButton(int colorNum)
    {
        if(colorNum == colorsInOrder[colorsIndex])
        {
            colorCorrect();
        }
        else
        {
            colorWrong();
        }
    }

    private void colorCorrect()
    {
        colorsIndex++;
        if(colorsIndex >= colorsInOrder.Length)
        {
            colorsIndex = 0;
            StartCoroutine(finishedGood());
        }
    }

    private IEnumerator finishedGood()
    {
        failWinText.text = "Success!";
        redButton.SetActive(false);
        blueButton.SetActive(false);
        greenButton.SetActive(false);
        yellowButton.SetActive(false);
        yield return new WaitForSecondsRealtime(delayTime);
        failWinText.text = "";
        activator.GetComponent<DisableManager>().disableObject(true);
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }

    private void colorWrong()
    {
        colorsIndex = 0;
        StartCoroutine(finishedBad());
    }

    private IEnumerator finishedBad()
    {
        failWinText.text = "Wrong!";
        redButton.SetActive(false);
        blueButton.SetActive(false);
        greenButton.SetActive(false);
        yellowButton.SetActive(false);
        yield return new WaitForSecondsRealtime(delayTime);
        failWinText.text = "";
        activator.GetComponent<DisableManager>().disableObject(false);
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }
}
