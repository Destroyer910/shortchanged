using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDetection : MonoBehaviour
{
    float delay = 0.1f;
    PlayerManager playerManager;
    bool isInTrigger = false;
    void OnTriggerEnter(Collider other)
    {
        isInTrigger = true;
        playerManager = other.GetComponent<PlayerManager>();
        StartCoroutine(IncreaseDetectionLevel());
    }
    private void OnTriggerExit(Collider other)
    {
        isInTrigger = false;
        StopCoroutine(IncreaseDetectionLevel());
        StartCoroutine(DecreaseDetectionLevel());
    }
    IEnumerator IncreaseDetectionLevel()
    {
        while (playerManager.getDetectionLevel() < playerManager.getMaxDetection() && isInTrigger)
        {
            yield return new WaitForSeconds(delay);
            playerManager.addDetectionLevel((int)playerManager.getDetectionSpeed());
        }
    }
    IEnumerator DecreaseDetectionLevel()
    {
        while (playerManager.getDetectionLevel() > 0 && !isInTrigger)
        {
            yield return new WaitForSeconds(delay);
            playerManager.addDetectionLevel((int)playerManager.getDetectionSpeed()*-1);
        }
    }
}
