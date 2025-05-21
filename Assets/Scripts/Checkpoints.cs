using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    CharacterController2D characterController2D;


    private BoxCollider2D checkPointCollider;

    private void Awake()
    {
        characterController2D = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterController2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            characterController2D.UpdateCheckpoint(transform.position);
        }    
    }
}
