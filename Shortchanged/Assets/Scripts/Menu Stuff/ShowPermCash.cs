using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowPermCash : MonoBehaviour
{
    public GameObject PlayerManager;

    private void Update()
    {
        string value = "$"+PlayerManager.GetComponent<PlayerManager>().getPermCash();
        this.GetComponent<TMP_Text>().text = value;
    }
}
