using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public SaveSystem saveSystem = new SaveSystem();
    public SaveSystem loadGame;
    private int MaxHealth;
    private float JumpHeight;
    protected float MaxSpeed;
    private float MaxSprintSpeed;
    private float DetectionRadius;

    private void Start()
    {
        loadGame = JsonUtility.FromJson<SaveSystem>(saveSystem.LoadFile());

        MaxHealth = loadGame.getHealth();
        JumpHeight = loadGame.getJumpHeight();
        MaxSpeed = loadGame.getSpeed();
        MaxSprintSpeed = loadGame.getSprintSpeed();
        DetectionRadius = loadGame.getDetectionRadius();

        print(JsonUtility.ToJson(loadGame));
    }
}
