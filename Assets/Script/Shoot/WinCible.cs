using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCible : MonoBehaviour
{
    public Transform[] Cibles;
    [SerializeField] private Canvas canvasToControl;
    private int destroyedCiblesCount = 0;
    public StatShoot stat;
    public string scenename;

    void Start()
    {
        if (stat == null)
        {
            stat = FindObjectOfType<StatShoot>();
        }
    }
    public void CibleDestroyed()
    {
        destroyedCiblesCount++;
        if (destroyedCiblesCount >= Cibles.Length)
        {
            canvasToControl.enabled = true;
            stat.StopTime();
        }
    }

    public void ReturnHub()
    {
        SceneManager.LoadScene(scenename);
    }
}
