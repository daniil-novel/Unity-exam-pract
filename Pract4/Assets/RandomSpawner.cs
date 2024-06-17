using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject prefab;
    public float spawnRadius = 15f;

    void Start()
    {
        SpawnPrefab();
    }

    void SpawnPrefab()
    {
        Vector3 randomPosition = new Vector3(
            Random.Range(-spawnRadius, spawnRadius), 0, Random.Range(-spawnRadius, spawnRadius)
        );

        Instantiate(prefab, randomPosition, Quaternion.identity); // Это для создания объекта на сцене
    }
}
