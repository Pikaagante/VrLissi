using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatTowerDefense : MonoBehaviour
{
    [SerializeField] private Text dialogueText;
    public int PvCastle = 20;

    void Update()
    {
        UpdateCanvas();
    }

    public void UpdateCanvas()
    {
        string displayText = "Point de vie restant = " + PvCastle.ToString() + "/20";

        dialogueText.text = displayText;
    }

    public void SetPv()
    {
        PvCastle -= 1;
    }
}
