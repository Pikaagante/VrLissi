using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCible : MonoBehaviour
{
    public Stat stat;
    public GameObject DestructObject;

    void Start()
    {
        if (stat == null)
        {
            stat = FindObjectOfType<Stat>();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            stat.StartTime();
            Destroy(DestructObject);
        }
    }
}
