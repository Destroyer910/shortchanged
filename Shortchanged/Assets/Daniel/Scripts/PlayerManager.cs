using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    SaveGameObject loadSystem = new SaveGameObject();
    public SaveSystem saveGame;
    public float JumpHeight;
    public float Speed;
    public float SprintSpeed;
    public float DetectionRadius;
    public float Sensitivity;
    public int cash;

    private void Start()
    {
        loadSystem = JsonUtility.FromJson<SaveSystem>(saveSystem.LoadFile());

        JumpHeight = saveGame.getJumpHeight();
        Speed = saveGame.getSpeed();
        SprintSpeed = saveGame.getSprintSpeed();
        DetectionRadius = saveGame.getDetectionRadius();
        Sensitivity = saveGame.getSensitivity();
        cash = loadGame.getCash();

        print(JsonUtility.ToJson(loadGame));
    }

    public void SavePlayerStuff() {
        loadSystem.SaveFile(saveGame);
    }
}
