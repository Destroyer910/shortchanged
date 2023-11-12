using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowText : MonoBehaviour
{
    public TMP_Text notifText;
    public float waitTime = 5f;

    public void updateText(string textToShow)
    {
        notifText.text = textToShow;
        StartCoroutine(dissapearInASec());
    }

    private IEnumerator dissapearInASec()
    {
        yield return new WaitForSecondsRealtime(waitTime);
        notifText.text = "";
    }
}
