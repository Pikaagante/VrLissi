using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float bulletSpeed = 10f;
    public Stat stat;

    void Start()
    {
        if (stat == null)
        {
            stat = FindObjectOfType<Stat>();
        }
    }

    public void FireBullet()
    {
        if (bullet == null || spawnPoint == null)
        {
            Debug.LogError("Bullet prefab or spawnPoint not assigned in Fire script.");
            return;
        }

        if (stat == null)
        {
            Debug.LogError("Stat reference not found or assigned in Fire script.");
            return;
        }

        GameObject spawnBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
        Rigidbody bulletRigidbody = spawnBullet.GetComponent<Rigidbody>();
        bulletRigidbody.useGravity = false;
        bulletRigidbody.velocity = spawnPoint.forward * bulletSpeed;

        stat.SetShoot(stat.Shoot + 1); // Increment Shoot count

        Destroy(spawnBullet, 5f);
    }
}