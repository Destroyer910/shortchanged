using System;
using System.Threading;
using System.Net.NetworkInformation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.UIElements;

public class PlayerMovement : PlayerManager
{
    public CharacterController controller;

    [SerializeField] private float speed;
    private static float gravity = -9.80665f;
    public GameObject FailScreen;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;
    private AudioSource walkingAudio;

    bool pass = false;

    public void doStartStuff() 
    {
        walkingAudio = GetComponent<AudioSource>();
        speed = base.getSpeed();   
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        //Sprint if the user is holding left shift;
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = base.getSprintSpeed();
            Debug.Log(speed);
        }
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = base.getSpeed();
        }
        if(DetectionLevel == maxDetection) {
            if (!pass)
            {
                pass = true;
                Time.timeScale = 0;
                addPermCash(-50);
                SavePlayerStuff();
                FailScreen.SetActive(true);
                UnityEngine.Cursor.lockState = CursorLockMode.None;
            }

        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (controller.velocity.normalized.x > 0 || controller.velocity.normalized.z > 0) {
            walkingAudio.pitch = speed / base.getSpeed();
            if (!walkingAudio.isPlaying)
            {
                walkingAudio.Play();
                print("Walking!");
            }

        } else
        {
            walkingAudio.Stop();
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.F2))
        {
            base.SavePlayerStuff();
        }
    }
}
