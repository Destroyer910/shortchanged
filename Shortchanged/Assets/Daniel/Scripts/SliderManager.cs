using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderManager : MonoBehaviour
{
    public GameObject Player;
    void Update()
    {
        Player.GetComponent<PlayerManager>();
    }
}
