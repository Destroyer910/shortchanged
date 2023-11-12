using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    SaveSystem loadSystem = new SaveSystem();
    public SaveSystem saveGame;
    public float JumpHeight;
    public float Speed;
    public float SprintSpeed;
    public float DetectionRadius;
    public float Sensitivity;
    public int cash;

    private void Start()
    {
        saveGame = JsonUtility.FromJson<SaveSystem>(loadSystem.LoadFile());

        JumpHeight = saveGame.getJumpHeight();
        Speed = saveGame.getSpeed();
        SprintSpeed = saveGame.getSprintSpeed();
        DetectionRadius = saveGame.getDetectionRadius();
        Sensitivity = saveGame.getSensitivity();
        cash = saveGame.getCash();

        print(JsonUtility.ToJson(saveGame));
    }

    public void SavePlayerStuff() {
        loadSystem.SaveFile(saveGame);
    }
}
