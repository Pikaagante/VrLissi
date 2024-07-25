using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Potion : MonoBehaviour
{
    public string scenename;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Sol"))
        {
            SceneManager.LoadScene(scenename);
        }
    }
}
