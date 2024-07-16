using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject DestructObject;
    public Stat stat;
    public WinCible winCible;
    void Start()
    {
        if (stat == null)
        {
            stat = FindObjectOfType<Stat>();
        }

        if (winCible == null)
        {
            winCible = FindObjectOfType<WinCible>();
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Weapon"))
        {
            Destroy(DestructObject);
            stat.SetCibleShoot(stat.CibleShoot + 1);
            if (winCible != null)
            {
                winCible.CibleDestroyed();
            }
        }
    }
}


