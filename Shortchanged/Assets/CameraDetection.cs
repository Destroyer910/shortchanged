using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDetection : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        PlayerManager playerManager = other.GetComponent<PlayerManager>();
        playerManager.setDetectionLevel((int)(playerManager.getDetectionLevel() + playerManager.getDetectionSpeed()));
    }
}
