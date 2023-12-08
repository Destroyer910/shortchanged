using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Typewritter : MonoBehaviour
{
    
    public string textToChange;
    public TMP_Text text;
    public float typeSpeed = 0.01f;
    
    public void startTextUpdate(string newText)
    {
        textToChange = newText;
        text.text = "Description: ";
        StopCoroutine("typewriterText");
        StartCoroutine("typewriterText");
    }

    private IEnumerator typewriterText()
    {
        string tempText = textToChange;
    
        foreach (char c in tempText) 
		{
			text.text += c;
			yield return new WaitForSeconds (typeSpeed);
		}
    }
}
