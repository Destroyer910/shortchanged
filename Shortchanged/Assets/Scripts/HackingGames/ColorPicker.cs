using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColorPicker : MonoBehaviour
{

    private int color = 0;
    public TMP_Text colorText;
    public float delayTime = 4;

    public void startMiniGame()
    {
        color = Random.Range(0,3);
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
        yield return new WaitForSeconds(delayTime);
        gameObject.SetActive(false);
    }

    private IEnumerator wrong()
    {
        colorText.text = "Incorrect";
        yield return new WaitForSeconds(delayTime);
        startMiniGame();
    }
}
