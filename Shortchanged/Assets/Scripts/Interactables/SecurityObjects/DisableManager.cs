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
        if(gameObject.tag == "ColorHack")
        {
            gameObject.GetComponent<HackingKeyColor>().disable(passed);
        }
        if(gameObject.tag == "CodeHack")
        {
            gameObject.GetComponent<HackingKeyCode>().disable(passed);
        }
        if(gameObject.tag == "SimonSays")
        {
            gameObject.GetComponent<HackingKeySimonSays>().disable(passed);
        }
    }
}
