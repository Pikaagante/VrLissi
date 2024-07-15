using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Potion1 : MonoBehaviour
{
    public string scenename2;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Sol"))
        {
            SceneManager.LoadScene(scenename2);
        }
    }
}
