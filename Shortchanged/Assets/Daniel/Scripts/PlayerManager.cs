using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    SaveSystem loadSystem = new SaveSystem();
    private SaveSystem saveGame;
    private float JumpHeight;
    private float Speed;
    private float SprintSpeed;
    private float DetectionSpeed;
    private float Sensitivity;
    private int permCash;
    private int levelCash;
    private int DetectionLevel;
    private int maxDetection;

    private void Start()
    {
        saveGame = JsonUtility.FromJson<SaveSystem>(loadSystem.LoadFile());

        JumpHeight = saveGame.getJumpHeight();
        Speed = saveGame.getSpeed();
        SprintSpeed = saveGame.getSprintSpeed();
        DetectionSpeed = saveGame.getDetectionSpeed();
        Sensitivity = saveGame.getSensitivity();
        permCash = saveGame.getPermCash();
        levelCash = 0;
        maxDetection = saveGame.getMaxDetection();

        print(JsonUtility.ToJson(saveGame));
    }
    public void SavePlayerStuff() {
        loadSystem.SaveFile(saveGame);
    }
    public float getJumpHeight() { return JumpHeight; }
    public float getSpeed() { return Speed; }
    public float getSprintSpeed() { return SprintSpeed; }
    public float getDetectionSpeed() { return DetectionSpeed; }
    public float getSensitivity() { return Sensitivity; }
    public int getPermCash() { return permCash; }
    public int getLevelCash() { return levelCash; }
    public int getDetectionLevel() { return DetectionLevel; }
    public int getMaxDetection() { return maxDetection; }

    public void setJumpHeight(float newJumpHeight) {
        JumpHeight = newJumpHeight;
        saveGame.setJumpHeight(newJumpHeight);
    }
    public void setSpeed(float newSpeed) {
        Speed = newSpeed;
        saveGame.setJumpHeight(newSpeed);
    }
    public void setSprintSpeed(float newSprintSpeed) {
        SprintSpeed = newSprintSpeed;
        saveGame.setSprintSpeed(newSprintSpeed);
    }
    public void setDetectionSpeed(float newDetectionRadius) {
        DetectionSpeed = newDetectionRadius;
        saveGame.setDetectionSpeed(newDetectionRadius);
    }
    public void setSensitivity(float newSensitivity) {
        Sensitivity = newSensitivity;
        saveGame.setSensitivity(newSensitivity);
    }
    public void setPermCash(int newCash) {
        permCash = newCash;
        saveGame.setPermCash(newCash);
    }
    public void addPermCash(int addCash) {
        permCash += addCash;
        saveGame.addCash(addCash);
    }
    public void setLevelCash(int newLevelCash) {
        levelCash = newLevelCash;
    }
    public void addLevelCash(int addCash) {
        levelCash += addCash;
    }
    public void setDetectionLevel(int newDetectionLevel) {
        DetectionLevel = newDetectionLevel;
    }
    public void addDetectionLevel(int addLevel) {
        DetectionLevel += addLevel;
    }
    public void setMaxDetection(int newMax) {
        maxDetection = newMax;
        saveGame.setMaxDetection(newMax);
    }
}
