using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform[] spawnPoints; // Points de spawn pour les ennemis
    public GameObject enemyPrefab; // Prefab de l'ennemi
    public int[] enemiesPerWave = { 6, 12, 18 }; // Nombre d'ennemis par vague
    private int currentWave = 0; // Vague actuelle

    // Listes de waypoints pour chaque route
    public Transform[] route1Waypoints;
    public Transform[] route2Waypoints;
    public Transform[] route3Waypoints;

    public StatTowerDefense statTowerDefense;

    void Start()
    {
        if (statTowerDefense == null)
        {
            statTowerDefense = FindObjectOfType<StatTowerDefense>();
            if (statTowerDefense == null)
            {
                Debug.LogError("StatTowerDefense n'a pas été trouvé dans la scène.");
                return; 
            }
        }

        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        while (currentWave < enemiesPerWave.Length)
        {
            statTowerDefense.SetVague(currentWave + 1); //Permet d'afficher le numéro de la vague
            for (int i = 0; i < enemiesPerWave[currentWave]; i++)
            {
                int spawnIndex = Random.Range(0, spawnPoints.Length); // Permet de générer un nbr pour avoir une route aléatoire
                Transform spawnPoint = spawnPoints[spawnIndex]; // Assigner le spawnpoint de la route
                GameObject enemy = Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);

                // Assigner les waypoints en fonction de la route choisie
                EnemyPatrolTowerDefense enemyPatrol = enemy.GetComponent<EnemyPatrolTowerDefense>();
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
                    }
                }

                yield return new WaitForSeconds(5); // Attendre 5 secondes avant de faire apparaître le prochain ennemi
            }

            yield return new WaitForSeconds(10); // Attendre 10 secondes avant de commencer la prochaine vague

            currentWave++;
        }
    }
}