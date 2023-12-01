using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDetection : MonoBehaviour
{
    float delay = 0.1f;
    PlayerManager playerManager;
    PlayerMovement playerMovement;
    bool isInTrigger = false;
    void OnTriggerEnter(Collider other)
    {
        this.GetComponent<Light>().enabled = true;
        isInTrigger = true;
        playerManager = other.GetComponent<PlayerManager>();
        playerMovement = other.GetComponent<PlayerMovement>();
        playerMovement.isDetected = true;
    }
    private void OnTriggerExit(Collider other)
    {
        playerMovement.isDetected = false;
        this.GetComponent<Light>().enabled = false;
        isInTrigger = false;
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
