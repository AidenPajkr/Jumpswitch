using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{

    CharacterController2D characterController2D;

    private void Start()
    {
        characterController2D = GetComponent<CharacterController2D>();
    }

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {       
            if (characterController2D.m_Grounded)
            {
                
            }
        }
    }

}
