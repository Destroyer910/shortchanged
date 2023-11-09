using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateSensitivity : MonoBehaviour
{

    public CameraMovement cameraScript;
    public Slider sensitivitySlider;
    public PlayerManager playerManagerScript;

    public void updateSensitivity()
    {
        playerManagerScript.Sensitivity = sensitivitySlider.value * 1000 + 1250;
        cameraScript.mouseSensitivity = playerManagerScript.Sensitivity;
    }
}
