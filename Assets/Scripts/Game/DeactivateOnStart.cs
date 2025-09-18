using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateOnStart : MonoBehaviour
{
    public GameObject[] Deactivate;

    void Start()
    {
        foreach (GameObject obj in Deactivate)
        {
            obj.SetActive(false);
        }
        
    }

}
