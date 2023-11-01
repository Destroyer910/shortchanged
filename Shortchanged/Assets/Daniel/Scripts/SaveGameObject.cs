using System;
using UnityEngine;

[Serializable]
public class SaveGameObject
{
    public int Health;
    public float JumpHeight;
    public float Speed;
    public float SprintSpeed;
    public float DetectionRadius;

    private const int DEFAULT_HEALTH = 100;
    private const float DEFAULT_JUMP_HEIGHT = 10f;
    private const float DEFAULT_SPEED = 5f;
    private const float DEFAULT_SPRINT_SPEED = 15f;
    private const float DEFAULT_DETECTION_RADIUS = 1.0f;

    public SaveGameObject(int health, float jumpHeight, float speed, float sprintSpeed, float detectionRadius)
    {
        setHealth(health);
        setJumpHeight(jumpHeight);
        setSpeed(speed);
        setSprintSpeed(sprintSpeed);
        setDetectionRadius(detectionRadius);
    }

    public SaveGameObject()
    {
        setHealth(DEFAULT_HEALTH);
        setJumpHeight(DEFAULT_JUMP_HEIGHT);
        setSpeed(DEFAULT_SPEED);
        setSprintSpeed(DEFAULT_SPRINT_SPEED);
        setDetectionRadius(DEFAULT_DETECTION_RADIUS);
    }

    public int getHealth() { return Health; }
    public float getJumpHeight() { return JumpHeight; }
    public float getSpeed() {  return Speed; }
    public float getSprintSpeed() { return SprintSpeed; }
    public float getDetectionRadius() {  return DetectionRadius; }

    public void setHealth(int health)
    {
        if (health > 0) { Health = health; }
    }
    public void setJumpHeight(float jumpHeight)
    {
        if (jumpHeight > 0) { JumpHeight = jumpHeight; }
    }
    public void setSpeed(float speed)
    {
        if (speed > 0) { Speed = speed; }
    }
    public void setSprintSpeed(float sprintSpeed)
    {
        if (sprintSpeed > 0) { SprintSpeed = sprintSpeed; }
    }
    public void setDetectionRadius(float detectionRadius)
    {
        if (detectionRadius > 0) { DetectionRadius = detectionRadius; }
    }
}
