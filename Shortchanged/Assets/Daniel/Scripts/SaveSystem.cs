using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;

public class SaveSystem : SaveGameObject
{
    String filePath = "";
    FileStream file;

    public void SaveFile(SaveSystem saveSystem)
    {
        filePath = Application.persistentDataPath + "/save.dat";
        print(filePath);
        if (!File.Exists(filePath))
        {
            file = File.Create(filePath);
        }

        File.WriteAllText(filePath, JsonUtility.ToJson(saveSystem));
    }

    public void LoadFile(SaveSystem saveSystem)
    {
        filePath = Application.persistentDataPath + "/save.dat";
        if (!File.Exists(filePath))
        {
            file = File.Create(filePath);
        }

        saveSystem = (SaveSystem)JsonUtility.FromJson<SaveGameObject>(File.ReadAllText(filePath));
    }
}
