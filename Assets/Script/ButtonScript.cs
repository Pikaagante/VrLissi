using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] private Text dialogueText;
    [SerializeField] private string[] dialogues;
    [SerializeField] private string[] dialoguesEpee;
    [SerializeField] private string[] dialoguesWeapon;
    [SerializeField] private Canvas canvasToControl;
    [SerializeField] private GameObject potion;
    [SerializeField] private GameObject potion2;
    [SerializeField] private Transform spawnPoint;
    private int dialogueIndex = 0;
    private int Dialog;

    public void NextDialogue()
    {
        if (dialogueIndex < dialogues.Length)
        {
            dialogueText.text = dialogues[dialogueIndex];
            dialogueIndex++; 
        }
        else
        {
            if (Dialog == 2)
            {
                GameObject spawnPotion = Instantiate(potion, spawnPoint.position, spawnPoint.rotation);
                Rigidbody potionRigidbody = spawnPotion.GetComponent<Rigidbody>();
                potionRigidbody.useGravity = false;
            }
            else if (Dialog == 3)
            {
                GameObject spawnPotion = Instantiate(potion2, spawnPoint.position, spawnPoint.rotation);
                Rigidbody potionRigidbody = spawnPotion.GetComponent<Rigidbody>();
                potionRigidbody.useGravity = false;
            }
            canvasToControl.enabled = false;
            dialogueIndex = 0;
            dialogueText.text = dialogues[dialogueIndex];
            }
        }

    public void SetDialog(int dialogIndex)
    {
        Dialog = dialogIndex; 
    }
}

