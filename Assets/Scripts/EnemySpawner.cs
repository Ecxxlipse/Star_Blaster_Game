using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] waveConfigSO[] waveConfigs;
    [SerializeField] float timeBetweenWaves = 1f;
    waveConfigSO currentWave;
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        foreach (waveConfigSO wave in waveConfigs)
        {
            currentWave = wave;
            for (int i = 0; i < currentWave.GetEnemyCount(); i++)
            {
                Instantiate(
                    currentWave.GetEnemyPrefab(0), 
                    currentWave.GetStartingWaypoint().position, 
                    Quaternion.identity, 
                    transform); 

                yield return new WaitForSeconds(currentWave.GetRandomEnemySpawnTime());
            } 
            yield return new WaitForSeconds(timeBetweenWaves);
        }
    }

    public waveConfigSO GetCurrentWave()
    {
        return currentWave;
    }

}
