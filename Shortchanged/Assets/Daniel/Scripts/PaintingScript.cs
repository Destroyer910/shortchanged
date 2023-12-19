using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingScript : MonoBehaviour
{
    public void makeNoise()
    {
        AudioSource[] audios = GetComponents<AudioSource>();
        audios[Random.Range(0, audios.Length)].Play();
    }
}
