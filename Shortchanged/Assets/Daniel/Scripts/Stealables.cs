using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Stealables : MonoBehaviour
{
    public int CashValue;
    public void stealItem(PlayerManager managerScript) {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();

        Debug.Log("Item stolen worth $"+CashValue);
        managerScript.addLevelCash(CashValue);
        Destroy(GetComponent<MeshCollider>());
        Destroy(GetComponent<MeshRenderer>());
    }
}
