using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Stealables : MonoBehaviour
{
    public int CashValue;
    public GameObject floatingText;
    private bool isInTrigger;
    private PlayerManager managerScript;

    private void OnTriggerEnter(Collider other)
    {
        managerScript = other.GetComponent<PlayerManager>();
        floatingText.SetActive(true);
        isInTrigger = true;
    }
    private void OnTriggerExit(Collider other)
    {
        floatingText.SetActive(false);
        isInTrigger = false;
    }
    private void Update()
    {
        if (isInTrigger && Input.GetKeyDown(KeyCode.E))
        {
            stealItem();
        }
    }
    public void stealItem() {
        Debug.Log("Item stolen worth $"+CashValue);
        managerScript.addLevelCash(CashValue);
        Destroy(gameObject);
    }
}
