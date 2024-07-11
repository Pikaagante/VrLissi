using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] private Text dialogueText;
    [SerializeField] private string[] dialogues;
    [SerializeField] private Canvas canvasToControl;
    private int dialogueIndex = 0; 

    public void NextDialogue()
    {
        if (dialogueIndex < dialogues.Length)
        {
            dialogueText.text = dialogues[dialogueIndex];
            dialogueIndex++; 
        }
        else
        {
            canvasToControl.enabled = false;
            dialogueIndex = 0;
            dialogueText.text = dialogues[dialogueIndex];
        }
    }
}

