using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;

public class SaveSystem : SaveGameObject
{
    String filePath;
    FileStream file;

    private void Start()
    {
        filePath = Application.persistentDataPath + "/save.dat";
    }

    public void SaveFile(SaveSystem saveSystem)
    {
        if (File.Exists(filePath))
        {
            file = File.OpenWrite(filePath);
        }
        else
        {
            file = File.Create(filePath);
        }

        File.WriteAllText(filePath, JsonUtility.ToJson(saveSystem));
    }

    public void LoadFile(SaveSystem saveSystem)
    {
        if (File.Exists(filePath))
        {
            file = File.OpenRead(filePath);
        }
        else
        {
            file = File.Create(filePath);
        }

        saveSystem = (SaveSystem)JsonUtility.FromJson<SaveGameObject>(File.ReadAllText(filePath));
    }
}
