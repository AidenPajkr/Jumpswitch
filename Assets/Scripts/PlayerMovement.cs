using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    private FootstepController footstepController;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;

    private void Awake()
    {
        footstepController = GetComponentInChildren<FootstepController>();
    }
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (controller.m_Grounded && (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D)))
        {
            footstepController.isWalking = true;
        }
        
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            footstepController.isWalking = false;
        }

    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;
    }
}
