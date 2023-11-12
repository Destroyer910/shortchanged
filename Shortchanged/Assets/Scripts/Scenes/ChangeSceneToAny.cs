using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneToAny : MonoBehaviour
{
    public void changeToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
