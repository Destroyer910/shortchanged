using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public SaveSystem saveSystem = new SaveSystem();
    public SaveSystem loadGame;
    private float JumpHeight;
    protected float MaxSpeed;
    private float MaxSprintSpeed;
    private float DetectionRadius;
    private int cash;

    private void Start()
    {
        loadGame = JsonUtility.FromJson<SaveSystem>(saveSystem.LoadFile());

        JumpHeight = loadGame.getJumpHeight();
        MaxSpeed = loadGame.getSpeed();
        MaxSprintSpeed = loadGame.getSprintSpeed();
        DetectionRadius = loadGame.getDetectionRadius();
        cash = loadGame.getCash();

        print(JsonUtility.ToJson(loadGame));
    }

    public void SavePlayerStuff() {
        saveSystem.SaveFile(loadGame);
    }
}
