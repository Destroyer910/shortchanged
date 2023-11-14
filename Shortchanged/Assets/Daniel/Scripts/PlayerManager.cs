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

        print(JsonUtility.ToJson(saveGame));
    }
    public void SavePlayerStuff() {
        loadSystem.SaveFile(saveGame);
    }
    public float getJumpHeight() { return JumpHeight; }
    public float getSpeed() { return Speed; }
    public float getSprintSpeed() { return SprintSpeed; }
    public float getDetectionRadius() { return DetectionSpeed; }
    public float getSensitivity() { return Sensitivity; }
    public int getPermCash() { return permCash; }
    public int getLevelCash() { return levelCash; }
    public int getDetectionLevel() { return DetectionLevel; }

    public void setJumpHeight(float newJumpHeight) {
        JumpHeight = newJumpHeight;
    }
    public void setSpeed(float newSpeed) {
        Speed = newSpeed;
    }
    public void setSprintSpeed(float newSprintSpeed) {
        SprintSpeed = newSprintSpeed;
    }
    public void setDetectionRadius(float newDetectionRadius) {
        DetectionSpeed = newDetectionRadius;
    }
    public void setSensitivity(float newSensitivity) {
        Sensitivity = newSensitivity;
    }
    public void setPermCash(int newCash) {
        permCash = newCash;
    }
    public void addPermCash(int addCash) {
        permCash += addCash;
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
}
