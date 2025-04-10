using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCondition : MonoBehaviour
{
    private Transform respawnPosition;

    void Start()
    {
        respawnPosition.position = GameObject.FindWithTag("Respawn").transform.position;
    }
    void OnTriggerEnter2D (Collider2D other)
    {
        Debug.Log("We've collided!");

        if (other.gameObject.tag == "Player")
        {
            other.transform.position = respawnPosition.position;
        }
    }
}
