using UnityEngine;

public class EnemyPatrolTowerDefense : MonoBehaviour
{
    public float speed;
    private Transform[] waypoints;

    private Transform target;
    private int destPoint = 0;

    public StatTowerDefense statTowerDefense;

    void Start()
    {
        if (statTowerDefense == null)
        {
            statTowerDefense = FindObjectOfType<StatTowerDefense>();
            if (statTowerDefense == null)
            {
                Debug.LogError("StatTowerDefense n'a pas été trouvé dans la scène.");
            }
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
            statTowerDefense.SetPv(); // Retirer 1 pv au chateau si l'ennemi atteint le dernier waypoint (porte)
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