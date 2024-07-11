using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PnjDialogue : MonoBehaviour
{
    [SerializeField] private Canvas canvasToControl;
    private ButtonScript buttonScript;

    private void Start()
    {
        buttonScript = FindObjectOfType<ButtonScript>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            buttonScript.SetDialog(1);
            canvasToControl.enabled = true;
        } else if (other.gameObject.CompareTag("Epee"))
        {
            buttonScript.SetDialog(3);
            canvasToControl.enabled = true;
        } else if (other.gameObject.CompareTag("Weapon"))
        {
            buttonScript.SetDialog(2);
            canvasToControl.enabled = true;
        }
    }

    public void Active()
    {
            canvasToControl.enabled = true;
    }
}
