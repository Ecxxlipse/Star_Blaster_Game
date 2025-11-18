using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] waveConfigSO currentWave;
    void Start()
    {
        SpawnEnemies();
    }

    void SpawnEnemies()
    {
        for (int i = 0; i < currentWave.GetEnemyCount(); i++)
        {
        Instantiate(
        currentWave.GetEnemyPrefab(0), 
        currentWave.GetStartingWaypoint().position, 
        Quaternion.identity, 
        transform); 
        }
    }

    public waveConfigSO GetCurrentWave()
    {
        return currentWave;
    }

}
