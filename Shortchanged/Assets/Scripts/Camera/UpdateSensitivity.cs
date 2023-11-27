using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateSensitivity : MonoBehaviour
{

    public CameraMovement cameraScript;
    public Slider sensitivitySlider;
    public PlayerManager playerManagerScript;

    void Start()
    {
        cameraScript.mouseSensitivity = playerManagerScript.getSensitivity();
        sensitivitySlider.value = (playerManagerScript.getSensitivity() - 1250) / 2000;
    }

    public void updateSensitivity()
    {
        playerManagerScript.setSensitivity(sensitivitySlider.value * 2000 + 1250);
        cameraScript.mouseSensitivity = playerManagerScript.getSensitivity();
        playerManagerScript.SavePlayerStuff();
    }
}
