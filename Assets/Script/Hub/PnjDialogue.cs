using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PnjDialogue : MonoBehaviour
{
    [SerializeField] private Canvas canvasToControl;
    private ButtonScript buttonScript;
    [SerializeField] private string[] dialogues;
    [SerializeField] private string[] dialoguesDrink;
    [SerializeField] private string[] dialoguesDish;

    private void Start()
    {
        buttonScript = FindObjectOfType<ButtonScript>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            buttonScript.SetDialog(1);
            buttonScript.SetDialogText(dialogues);
            canvasToControl.enabled = true;
        } else if (other.gameObject.CompareTag("drink"))
        {
            buttonScript.SetDialog(3);
            buttonScript.SetDialogText(dialoguesDrink);
            canvasToControl.enabled = true;
        } else if (other.gameObject.CompareTag("dish"))
        {
            buttonScript.SetDialog(2);
            buttonScript.SetDialogText(dialoguesDish);
            canvasToControl.enabled = true;
        }
    }

    public void Active()
    {
            canvasToControl.enabled = true;
    }
}
