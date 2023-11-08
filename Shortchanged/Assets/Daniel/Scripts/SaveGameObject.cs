using System;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;

[Serializable]
public class SaveGameObject
{
    public float JumpHeight;
    public float Speed;
    public float SprintSpeed;
    public float DetectionRadius;
    public int Cash;

    private const float DEFAULT_JUMP_HEIGHT = 10f;
    private const float DEFAULT_SPEED = 5f;
    private const float DEFAULT_SPRINT_SPEED = 15f;
    private const float DEFAULT_DETECTION_RADIUS = 1.0f;
    private const int DEFAULT_CASH = 0;

    public SaveGameObject() {
        setJumpHeight(DEFAULT_JUMP_HEIGHT);
        setSpeed(DEFAULT_SPEED);
        setSprintSpeed(DEFAULT_SPRINT_SPEED);
        setDetectionRadius(DEFAULT_DETECTION_RADIUS);
    }

    public SaveGameObject(float jumpHeight, float speed, float sprintSpeed, float detectionRadius) {
        setJumpHeight(jumpHeight);
        setSpeed(speed);
        setSprintSpeed(sprintSpeed);
        setDetectionRadius(detectionRadius);
    }

    public float getJumpHeight() { return JumpHeight; }
    public float getSpeed() {  return Speed; }
    public float getSprintSpeed() { return SprintSpeed; }
    public float getDetectionRadius() {  return DetectionRadius; }
    public int getCash() { return Cash; }

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
    public void setCash(int newCash) {
        Cash = newCash;
    }
    public void addCash(int plusCash) {
        Cash += plusCash;
    }
}
