using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    CharacterController2D characterController2D;
    
    public AudioClip passed;
    public bool audioPlayed = false;

    public Sprite greenBeam;
    public SpriteRenderer render;

    private BoxCollider2D checkPointCollider;

    private void Awake()
    {
        characterController2D = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterController2D>();
    }
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = passed;
    }

    // Update is called once per frame


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            characterController2D.UpdateCheckpoint(transform.position);
            render.sprite = greenBeam;
            
            if (audioPlayed == false)
            {
                GetComponent<AudioSource>().Play();
                audioPlayed = true;
            }
        }
    }
}
