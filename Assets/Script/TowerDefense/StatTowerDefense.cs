using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatTowerDefense : MonoBehaviour
{
    [SerializeField] private Text dialogueText;
    public int PvCastle = 20; // Nombre de point de vie restant au chateau
    public int Vague; // numéro de la vague
    public int EnnemisRestant; 

    void Update()
    {
        UpdateCanvas();
    }

    public void UpdateCanvas()
    {
        string displayText = "Point de vie restant = " + PvCastle.ToString() + "/20" + "\n" 
            + "Vague : " + Vague.ToString() + "/3" + "\n" 
            + "Ennemis restant : " + EnnemisRestant.ToString();

        dialogueText.text = displayText;
    }

    public void SetPv()
    {
        PvCastle -= 1;
    }

    public void SetVague(int vague)
    {
        Vague = vague;
    }
}
