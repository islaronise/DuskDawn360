using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager : MonoBehaviour
{
    [SerializeField] GameObject enemyBlueprint;

    float spawnTimer = 0f;
    [SerializeField] float spawnDelay = 0.2f;
    float spawnYMin = 1f;
    float spawnYMax = 1f;
    [SerializeField] float spawnHeight = 1f;


    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer > spawnDelay)
        {
            SpawnEnemy();
            spawnTimer = 0f;
        }
    }

    void SpawnEnemy()
    {
        float spawnY = (Random.Range(spawnYMin, spawnYMax) * spawnHeight);
        //print(spawnY);  
        GameObject enemy;
        enemy = Instantiate(enemyBlueprint, transform.position + new Vector3(0f, spawnY, 0f), transform.rotation);
    }
}
