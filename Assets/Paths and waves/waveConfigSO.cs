using UnityEngine;

[CreateAssetMenu(fileName = "waveConfigSO", menuName = "waveConfigSO")]
public class waveConfigSO : ScriptableObject
{
    [SerializeField] GameObject[] enemyPrefabs;
    [SerializeField] Transform pathPrefab;
    [SerializeField] float enemyMoveSpeed = 5f;
    [SerializeField] float timeBetweenEnemySpawns = 1f;
    [SerializeField] float enemySpawnVarience = 0f;
    [SerializeField] float minimumSpawnTime = 0.2f;

    public int GetEnemyCount()
    {
        return enemyPrefabs.Length;
    }

    public GameObject GetEnemyPrefab(int index)
    {
        return enemyPrefabs[index];
    }
    public Transform GetStartingWaypoint()
    {
        return pathPrefab.GetChild(0);
    }

    public float GetEnemyMoveSpeed()
    {
        return enemyMoveSpeed;
    }

    public Transform[] GetWaypoints()
    {
        Transform[] waypoints = new Transform[pathPrefab.childCount];

        for (int i = 0; i < pathPrefab.childCount; i++)
        {
            waypoints[i] = pathPrefab.GetChild(i);
        }

        return waypoints;
    }

    public float GetRandomEnemySpawnTime()
    {
        float spawnTime = Random.Range(timeBetweenEnemySpawns - enemySpawnVarience,
            timeBetweenEnemySpawns + enemySpawnVarience);
        
        spawnTime = Mathf.Clamp(spawnTime, minimumSpawnTime, float.MaxValue);

        return spawnTime;
    }
}
