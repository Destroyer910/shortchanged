using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectRotator : MonoBehaviour
{
    
    public float rotateSpeed;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0, Space.World);
    }
}
