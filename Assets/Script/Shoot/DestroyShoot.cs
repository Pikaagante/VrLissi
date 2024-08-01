using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyShoot : MonoBehaviour
{
    public StatShoot stat;
    public WinCible winCible;

    void Start()
    {
        if (stat == null)
        {
            stat = FindObjectOfType<StatShoot>();
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
            Destroy(gameObject);
            stat.SetCibleShoot(stat.CibleShoot + 1);
        }
    }
}


