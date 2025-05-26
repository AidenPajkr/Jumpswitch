using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour
{
    public GameObject[] ObstacleTiles;
   

    void Update()
    {
        foreach (GameObject obj in ObstacleTiles)
        { 
            if (Input.GetKeyDown(KeyCode.Return))
            {
                AudioManager.PlaySound(SoundType.click); 


                if (!obj.activeSelf)
                {
                    obj.SetActive(true);
                }
            
                else
                {
                    obj.SetActive(false);
                }
            }
        }
    }
}
