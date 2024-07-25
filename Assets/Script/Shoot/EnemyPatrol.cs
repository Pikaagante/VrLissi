using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed;
    public Transform[] waypoints;

    private Transform target;
    private int destPoint = 0;

    void Start()
    {
        GotoNextPoint();
    }

    void GotoNextPoint()
    {
        if (waypoints.Length == 0)
            return;
        target = waypoints[destPoint];
        destPoint = (destPoint + 1) % waypoints.Length;
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) < 0.3f)
        {
            GotoNextPoint();
        }
    }
}