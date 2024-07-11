using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PnjDialogue : MonoBehaviour
{
    [SerializeField] private Canvas canvasToControl;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canvasToControl.enabled = true;
        }
    }
}
