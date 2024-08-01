using UnityEngine;

public class EnemyPatrolShoot : MonoBehaviour
{
    public float speed;
    private Transform[] waypoints;

    private Transform target;
    private int destPoint = 0;

    public StatShoot stat;

    void Start()
    {
        if (stat == null)
        {
            stat = FindObjectOfType<StatShoot>();
        }
    }

    // Méthode pour définir les waypoints
    public void SetWaypoints(Transform[] newWaypoints)
    {
        waypoints = newWaypoints;
        destPoint = 0;
        if (waypoints.Length > 0)
        {
            target = waypoints[destPoint];
        }
    }

    // Aller au prochain point
    void GotoNextPoint()
    {
        destPoint++;

        if (destPoint >= waypoints.Length)
        {
            stat.SetCibleMiss();
            Destroy(gameObject); // Detruire l'ennemi
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