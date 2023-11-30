using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CashManager : MonoBehaviour
{
    public GameObject Player;

    private void Update()
    {
        string value = "$"+Player.GetComponent<PlayerManager>().getLevelCash();
        this.GetComponent<TMP_Text>().text = value;
    }
}
