using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrolTowerDefense : MonoBehaviour
{
    public float speed;
    public Transform[] waypoints;

    private Transform target;
    private int destPoint = 0;

    public StatTowerDefense statTowerDefense;

    void Start()
    {
        if (waypoints.Length > 0)
        {
            target = waypoints[destPoint];
        }

        if(statTowerDefense == null)
        {
            statTowerDefense = FindObjectOfType<StatTowerDefense>();
        }
    }

    void GotoNextPoint()
    {
        destPoint++;

        if (destPoint >= waypoints.Length)
        {
            statTowerDefense.SetPv();
            Destroy(gameObject);
            return; 
        }

        target = waypoints[destPoint];
    }

    void Update()
    {
        if (target == null) return;

        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        if (Vector3.Distance(transform.position, target.position) < 0.3f)
        {
            GotoNextPoint();
        }
    }
}