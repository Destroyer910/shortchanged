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
        startDelayed();
    }

    public void updateSensitivity()
    {
        playerManagerScript.setSensitivity(sensitivitySlider.value * 2000 + 1250);
        cameraScript.mouseSensitivity = playerManagerScript.getSensitivity();
        playerManagerScript.SavePlayerStuff();
    }
    IEnumerator startDelayed()
    {
        yield return new WaitForSeconds(0.1f);
        cameraScript.mouseSensitivity = playerManagerScript.getSensitivity();
        sensitivitySlider.value = playerManagerScript.getSensitivity();
    }
}
