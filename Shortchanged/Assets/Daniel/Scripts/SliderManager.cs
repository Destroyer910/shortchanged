using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour
{
    public GameObject Player;
    private PlayerManager playerManager;
    void Start(){
        playerManager = Player.GetComponent<PlayerManager>();
    }
    void Update()
    {
        this.GetComponent<Slider>().value = (float)playerManager.getDetectionLevel() / (float)playerManager.getMaxDetection();
    }
}
