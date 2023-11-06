using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public SaveSystem saveGame;
    private int MaxHealth;
    private float JumpHeight;
    private float MaxSpeed;
    private float MaxSprintSpeed;
    private float DetectionRadius;

    private void Start()
    {
        saveGame.SaveFile(saveGame);

        MaxHealth = saveGame.getHealth();
        JumpHeight = saveGame.getJumpHeight();
        MaxSpeed = saveGame.getSpeed();
        MaxSprintSpeed = saveGame.getSprintSpeed();
        DetectionRadius = saveGame.getDetectionRadius();

        print(JsonUtility.ToJson(saveGame));
    }
}
