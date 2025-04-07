using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        global::System.Object p = Debug.Log($"the gameObject named {collision.gameObject.name} and tagged {collision.gameObject.tag} was hit !",
                  collision.gameObject);

        if (collision.gameObject.tag CompareTag "Death")
        {
            Destroy(gameObject);
        }
    }
}
