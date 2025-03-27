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

        if (Input.GetMouseButton(1))
        {
            Debug.Log("Pressed right click.");
        }

        if (Input.GetMouseButton(2))
        {
            Debug.Log("Pressed middle click.");
        }
    }
}
