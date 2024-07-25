using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTowerDefense : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Weapon"))
        {
            Destroy(gameObject);
        }
    }
}


