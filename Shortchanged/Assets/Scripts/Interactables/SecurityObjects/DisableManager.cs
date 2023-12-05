using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableManager : MonoBehaviour
{
    public void disableObject(bool passed)
    {
        if(gameObject.tag == "TestDisable")
        {
            gameObject.GetComponent<TestObject>().disable(passed);
        }
    }
}
