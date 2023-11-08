using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject : MonoBehaviour
{
    public GameObject hackMenu;

    public void hackTest()
    {
        hackMenu.SetActive(true);
    }
}
