using System;
using System.Diagnostics;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;

[Serializable]
public class SaveGameObject
{
    public float JumpHeight;
    public float Speed;
    public float SprintSpeed;
    public float DetectionSpeed;
    public int permCash;
    public float Sensitivity;

    private const float DEFAULT_JUMP_HEIGHT = 10f;
    private const float DEFAULT_SPEED = 5f;
    private const float DEFAULT_SPRINT_SPEED = 15f;
    private const float DEFAULT_DETECTION_SPEED = 1.0f;
    private const int DEFAULT_PERM_CASH = 0;
    private const float DEFAULT_SENSITIVITY = 0;

    public SaveGameObject(int health, float jumpHeight, float speed, float sprintSpeed, float detectionRadius, float sensitivity, int newPermCash)
    {
        setJumpHeight(jumpHeight);
        setSpeed(speed);
        setSprintSpeed(sprintSpeed);
        setDetectionSpeed(detectionRadius);
        setSensitivity(sensitivity);
        setPermCash(newPermCash);
    }

    public SaveGameObject()
    {
        setJumpHeight(DEFAULT_JUMP_HEIGHT);
        setSpeed(DEFAULT_SPEED);
        setSprintSpeed(DEFAULT_SPRINT_SPEED);
        setDetectionSpeed(DEFAULT_DETECTION_SPEED);
        setSensitivity(DEFAULT_SENSITIVITY);
        setPermCash(DEFAULT_PERM_CASH);
    }

    public float getJumpHeight() { return JumpHeight; }
    public float getSpeed() {  return Speed; }
    public float getSprintSpeed() { return SprintSpeed; }
    public float getDetectionSpeed() {  return DetectionSpeed; }
    public int getPermCash() { return permCash; }
    public float getSensitivity() {  return Sensitivity; }

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
    public void setDetectionSpeed(float detectionRadius)
    {
        if (detectionRadius > 0) { DetectionSpeed = detectionRadius; }
    }
    public void setPermCash(int newCash) {
        permCash = newCash;
    }
    public void addCash(int plusCash) {
        permCash += plusCash;
    }
    public void setSensitivity(float sensitivity)
    {
        if (sensitivity >= 0) { Sensitivity = sensitivity; }
    }
}
