using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Availability : MonoBehaviour
{
    public PlayerManager playerManagerScript;
    public GameObject enterButton;
    public GameObject lockedText;
    public Material deactivatedMaterial;
    private Light theLight;

    void Start()
    {
        theLight = gameObject.GetComponent<Light>();
    }

    void Update()
    {
        if(!playerManagerScript.getUnlockedLevel2())
        {
            lockedText.SetActive(true);
            enterButton.transform.position = new Vector3(2000,2000,2000);
            theLight.color = deactivatedMaterial.color;
            gameObject.GetComponent<MeshRenderer>().material = deactivatedMaterial;
        }
    }
}
