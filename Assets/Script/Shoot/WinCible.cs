using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCible : MonoBehaviour
{
    [SerializeField] private Canvas canvasToControl;

    public string scenename;

    public void ReturnHub()
    {
        SceneManager.LoadScene(scenename);
    }
}
