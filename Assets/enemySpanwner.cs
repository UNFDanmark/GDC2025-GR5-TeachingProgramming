using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using Random = UnityEngine.Random;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float enemySpawnTimer;

    float xParam;
    float zParam;


    void Start()
    {
        xParam = this.transform.localScale.x/2;
        zParam = this.transform.localScale.z/2;

        StartCoroutine(SpawnEnemy());


    }

    IEnumerator SpawnEnemy()
    {
        
        yield return new WaitForSeconds(enemySpawnTimer);

        Vector3 spawnPosition = new Vector3(Random.Range(-xParam, xParam), -1, Random.Range(-zParam, xParam));

        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

        StartCoroutine(SpawnEnemy());
    }
    
    
}