using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableArray : MonoBehaviour
{
    public GameObject[] objectsToDisable;

    public void disableAllObjects()
    {
        for(int i = 0; i < objectsToDisable.Length; i++)
        {
            objectsToDisable[i].SetActive(false);
        }
    }
}
