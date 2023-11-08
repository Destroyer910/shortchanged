using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;

public class SaveSystem : SaveGameObject
{
    String filePath = "";
    FileStream file;

    public void SaveFile(SaveSystem saveSystem)
    {
        filePath = Application.persistentDataPath + "/save.dat";
        if (!File.Exists(filePath))
        {
            file = File.Create(filePath);
            file.Close();
        }
        Debug.Log(JsonUtility.ToJson(saveSystem));
        File.WriteAllText(filePath, JsonUtility.ToJson(saveSystem));
    }

    public String LoadFile()
    {
        filePath = Application.persistentDataPath + "/save.dat";
        if (!File.Exists(filePath))
        {
            SaveFile(this);
        }

        return File.ReadAllText(filePath);
    }
}
