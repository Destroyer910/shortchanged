using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Stealables : MonoBehaviour
{

    public int CashValue;
    public string displayTextOnGrab;
    private ShowText showTextScript;
    public bool isRequired;

    void Start()
    {
        showTextScript = GameObject.Find("UiDisplay").GetComponent<ShowText>();
    }

    public void stealItem(PlayerManager managerScript) {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();

        Debug.Log("Item stolen worth $"+CashValue);
        managerScript.addLevelCash(CashValue * managerScript.getCashMultiplyer());
        Destroy(GetComponent<MeshCollider>());
        Destroy(GetComponent<MeshRenderer>());
        showTextScript.updateText(displayTextOnGrab);
        if(isRequired)
        {
            GameObject.Find("Exit").GetComponent<LevelExit>().grabbedReqSteal();
        }
    }
}
