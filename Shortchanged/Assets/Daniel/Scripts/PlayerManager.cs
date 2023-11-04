using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    SaveGameObject saveGame = new SaveGameObject();
    public int Health;
    public float JumpHeight;
    public float Speed;
    public float SprintSpeed;
    public float DetectionRadius;

    private void Start()
    {
        Health = saveGame.getHealth();
        JumpHeight = saveGame.getJumpHeight();
        Speed = saveGame.getSpeed();
        SprintSpeed = saveGame.getSprintSpeed();
        DetectionRadius = saveGame.getDetectionRadius();

        print(JsonUtility.ToJson(saveGame));
    }
}
