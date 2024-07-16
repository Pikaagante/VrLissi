using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stat : MonoBehaviour
{
    [SerializeField] private Text dialogueText;
    public int Shoot;
    public int Time;
    public int CibleShoot;
    private bool isTiming = false;

    void Update()
    {
        UpdateCanvas();
    }

    public void UpdateCanvas()
    {
        string displayText = "Tir = " + Shoot.ToString() + "\n" +
                             "Time = " + Time.ToString() + "\n" +
                             "Cible touchée = " + CibleShoot.ToString();

        dialogueText.text = displayText;
    }

    public void SetShoot(int shoot)
    {
        Shoot = shoot;
    }

    public void StartTime()
    {
        if (!isTiming)
        {
            isTiming = true;
            StartCoroutine(TimerCoroutine());
        }
    }

    public void StopTime()
    {
        isTiming = false;
    }

    private IEnumerator TimerCoroutine()
    {
        while (isTiming)
        {
            yield return new WaitForSeconds(1);
            Time++; 
        }
    }

    public void SetCibleShoot(int cibleShoot)
    {
        CibleShoot = cibleShoot;
    }
}
