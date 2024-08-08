using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCible : MonoBehaviour
{
    [SerializeField] private Canvas canvasToControl;
    public string scenename;
    private float timer = 120f; 
    private bool timerStarted = false;

    void Start()
    {
        // Start the timer on Start
        StartCoroutine(StartTimer());
    }

    IEnumerator StartTimer()
    {
        timerStarted = true;
        while (timer > 0)
        {
            timer -= Time.deltaTime;
            yield return null;
        }
        canvasToControl.enabled = true;
    }

    public void ReturnHub()
    {
        SceneManager.LoadScene(scenename);
    }
}