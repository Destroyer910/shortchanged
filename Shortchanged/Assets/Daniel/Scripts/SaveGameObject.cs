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
    public int maxDetection;
    public bool unlockedLevel2;
    public int cashMultiplyer;
    public int cameraDisableCount;

    protected const float DEFAULT_JUMP_HEIGHT = 10f;
    protected const float DEFAULT_SPEED = 4f;
    protected const float DEFAULT_SPRINT_SPEED = 6f;
    protected const float DEFAULT_DETECTION_SPEED = 5.0f;
    protected const int DEFAULT_PERM_CASH = 0;
    protected const float DEFAULT_SENSITIVITY = 1000f;
    protected const int DEFAULT_MAX_DETECTION = 75;
    protected const bool DEFAULT_UNLOCKED_LEVEL_2 = false;
    protected const int DEFAULT_CASH_MULTIPLYER = 1;
    protected const int DEFAULT_CAMERA_DISABLE_COUNT = 0;
                            //Why is there health??!!?!?
    public SaveGameObject(int health, float jumpHeight, float speed, float sprintSpeed, float detectionRadius, float sensitivity, int newPermCash, int newMax, bool newLevel2, int newCashMultiplyer, int newCameraDisableCount)
    {
        setJumpHeight(jumpHeight);
        setSpeed(speed);
        setSprintSpeed(sprintSpeed);
        setDetectionSpeed(detectionRadius);
        setSensitivity(sensitivity);
        setPermCash(newPermCash);
        setMaxDetection(newMax);
        setUnlockedLevel2(newLevel2);
        setCashMultiplyer(newCashMultiplyer);
        setCameraDisableCount(newCameraDisableCount);
    }

    public SaveGameObject()
    {
        setJumpHeight(DEFAULT_JUMP_HEIGHT);
        setSpeed(DEFAULT_SPEED);
        setSprintSpeed(DEFAULT_SPRINT_SPEED);
        setDetectionSpeed(DEFAULT_DETECTION_SPEED);
        setSensitivity(DEFAULT_SENSITIVITY);
        setPermCash(DEFAULT_PERM_CASH);
        setMaxDetection(DEFAULT_MAX_DETECTION);
        setUnlockedLevel2(DEFAULT_UNLOCKED_LEVEL_2);
        setCashMultiplyer(DEFAULT_CASH_MULTIPLYER);
        setCameraDisableCount(DEFAULT_CAMERA_DISABLE_COUNT);
    }

    public float getJumpHeight() { return JumpHeight; }
    public float getSpeed() {  return Speed; }
    public float getSprintSpeed() { return SprintSpeed; }
    public float getDetectionSpeed() {  return DetectionSpeed; }
    public int getPermCash() { return permCash; }
    public float getSensitivity() {  return Sensitivity; }
    public int getMaxDetection() { return maxDetection; }
    public bool getUnlockedLevel2() { return unlockedLevel2; }
    public int getCashMultiplyer() { return cashMultiplyer; }
    public int getCameraDisableCount() { return cameraDisableCount; }

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
    public void setMaxDetection(int newMax) 
    {
        maxDetection = newMax;
    }
    public void setUnlockedLevel2(bool newLevel2)
    {
        unlockedLevel2 = newLevel2;
    }
    public void setCashMultiplyer(int newCashMultiplyer)
    {
        cashMultiplyer = newCashMultiplyer;
    }
    public void setCameraDisableCount(int newCameraDisableCount)
    {
        cameraDisableCount = newCameraDisableCount;
    }
}
