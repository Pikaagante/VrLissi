using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusique : MonoBehaviour
{
    public AudioSource audioSource;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Weapon"))
        {
            audioSource.Play();
        }
    }
}