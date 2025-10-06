using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    private FootstepController footstepController;
    public Animator animator;

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
            AudioManager.PlaySound(SoundType.jump);
            animator.SetTrigger("isJumping");
        }

        if (controller.m_Grounded && horizontalMove!=0)
        {
            footstepController.isWalking = true;
            animator.SetBool("isMoving", true);
        }       
        else
        {
            footstepController.isWalking = false;
            animator.SetBool("isMoving", false);
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;        
    }
}
