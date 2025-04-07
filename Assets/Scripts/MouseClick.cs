using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    public GameObject ObstacleTiles;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pressed left click.");

            if (!ObstacleTiles.activeSelf)
            {
                ObstacleTiles.SetActive(true);
            }
            
            else
            {
                ObstacleTiles.SetActive(false);
            }
        }

    }
}
