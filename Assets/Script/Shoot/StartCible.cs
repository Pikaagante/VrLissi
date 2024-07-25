using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCible : MonoBehaviour
{
    public Stat stat;
    public List<GameObject> cibles; 

    void Start()
    {
        if (stat == null)
        {
            stat = FindObjectOfType<Stat>();
        }

        foreach (GameObject cible in cibles)
        {
            cible.SetActive(false);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            stat.StartTime();
            // Activer toutes les cibles
            foreach (GameObject cible in cibles)
            {
                cible.SetActive(true);
            }
            Destroy(gameObject);
        }
    }
}