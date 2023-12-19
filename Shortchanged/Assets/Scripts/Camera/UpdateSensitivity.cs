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
        StartCoroutine("startDelayed");
    }

    public void updateSensitivity()
    {
        playerManagerScript.setSensitivity(sensitivitySlider.value);
        cameraScript.mouseSensitivity = playerManagerScript.getSensitivity();
        playerManagerScript.SavePlayerStuff();
    }
    IEnumerator startDelayed()
    {
        yield return new WaitForSeconds(0.1f);
        print(playerManagerScript.getSensitivity());
        cameraScript.mouseSensitivity = playerManagerScript.getSensitivity();
        sensitivitySlider.value = playerManagerScript.getSensitivity();
    }
}
