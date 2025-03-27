using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateOnStart : MonoBehaviour
{
    public GameObject Deactivate;

    void Start()
    {
        Deactivate.SetActive(false);
    }

}
