using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsSensitivity : MonoBehaviour
{
    private Slider slider;
    private SaveSystem loadGame;

    // Start is called before the first frame update
    void Start()
    {
        SaveSystem saveSystem = new SaveSystem();
        loadGame = JsonUtility.FromJson<SaveSystem>(saveSystem.LoadFile());
        slider = GetComponent<Slider>();

        slider.value = loadGame.getSensitivity();
    }
    public void ChangeSensitivity()
    {
        loadGame.setSensitivity(slider.value);
        loadGame.SaveFile(loadGame);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
