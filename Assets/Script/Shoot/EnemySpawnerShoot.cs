using System.Collections;
using UnityEngine;

public class EnemySpawnerShoot : MonoBehaviour
{
    public Transform[] spawnPoints; // Points de spawn pour les ennemis
    public GameObject enemyPrefab; // Prefab de l'ennemi
    public int[] enemiesPerWave = { 6, 12, 18 }; // Nombre d'ennemis par vague
    private int currentWave = 0; // Vague actuelle

    // Listes de waypoints pour chaque route
    public Transform[] route1Waypoints;
    public Transform[] route2Waypoints;
    public Transform[] route3Waypoints;
    public Transform[] route4Waypoints;
    public Transform[] route5Waypoints;
    public Transform[] route6Waypoints;
    public Transform[] route7Waypoints;
    public Transform[] route8Waypoints;
    public Transform[] route9Waypoints;
    public Transform[] route10Waypoints;

    [SerializeField] private Canvas canvaWin;


    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    void Update()
    {

        if (currentWave >= enemiesPerWave.Length)
        {
            canvaWin.enabled = true;
        }
    }

    IEnumerator SpawnWaves()
    {
        while (currentWave < enemiesPerWave.Length)
        {
            for (int i = 0; i < enemiesPerWave[currentWave]; i++)
            {
                int spawnIndex = Random.Range(0, spawnPoints.Length); // Permet de générer un nbr pour avoir une route aléatoire
                Transform spawnPoint = spawnPoints[spawnIndex]; // Assigner le spawnpoint de la route
                GameObject enemy = Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);

                // Assigner les waypoints en fonction de la route choisie
                EnemyPatrolShoot enemyPatrol = enemy.GetComponent<EnemyPatrolShoot>();
                if (enemyPatrol != null)
                {
                    switch (spawnIndex)
                    {
                        case 0: // Route 1
                            enemyPatrol.SetWaypoints(route1Waypoints);
                            break;
                        case 1: // Route 2
                            enemyPatrol.SetWaypoints(route2Waypoints);
                            break;
                        case 2: // Route 3
                            enemyPatrol.SetWaypoints(route3Waypoints);
                            break;
                        case 3: // Route 4
                            enemyPatrol.SetWaypoints(route4Waypoints);
                            break;
                        case 4: // Route 5
                            enemyPatrol.SetWaypoints(route5Waypoints);
                            break;
                        case 5: // Route 6
                            enemyPatrol.SetWaypoints(route6Waypoints);
                            break;
                        case 6: // Route 7
                            enemyPatrol.SetWaypoints(route7Waypoints);
                            break;
                        case 7: // Route 8
                            enemyPatrol.SetWaypoints(route8Waypoints);
                            break;
                        case 8: // Route 9
                            enemyPatrol.SetWaypoints(route9Waypoints);
                            break;
                        case 9: // Route 10
                            enemyPatrol.SetWaypoints(route10Waypoints);
                            break;
                    }
                }

                yield return new WaitForSeconds(1); // Attendre 1 secondes avant de faire apparaître le prochain ennemi
            }

            yield return new WaitForSeconds(10); // Attendre 10 secondes avant de commencer la prochaine vague

            currentWave++;
        }
    }
}