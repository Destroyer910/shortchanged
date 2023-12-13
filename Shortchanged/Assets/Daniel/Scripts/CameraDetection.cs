using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDetection : MonoBehaviour
{
    float delay = 0.1f;
    PlayerManager playerManager;
    bool isInTrigger = false;
    public double detectionSpeed = 1;
    void OnTriggerEnter(Collider other)
    {
        this.GetComponent<Light>().enabled = true;
        isInTrigger = true;
        playerManager = other.GetComponent<PlayerManager>();
        playerManager.isDetected = true;
    }
    private void OnTriggerExit(Collider other)
    {
        playerManager.isDetected = false;
        this.GetComponent<Light>().enabled = false;
        isInTrigger = false;
    }
}
