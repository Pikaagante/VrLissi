using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float bulletSpeed = 10f;

    public void FireBullet()
    {
        GameObject spawnBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
        Rigidbody bulletRigidbody = spawnBullet.GetComponent<Rigidbody>();
        bulletRigidbody.useGravity = false; // Désactive la gravité pour ce Rigidbody
        bulletRigidbody.velocity = spawnPoint.forward * bulletSpeed;
        Destroy(spawnBullet, 5f);
    }
}
