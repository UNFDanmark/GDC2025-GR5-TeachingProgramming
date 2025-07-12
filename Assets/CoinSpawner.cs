using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using Random = UnityEngine.Random;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public float coinSpawnTimer;

    float xParam;
    float zParam;


    void Start()
    {
        xParam = this.transform.localScale.x/2;
        zParam = this.transform.localScale.z/2;

        StartCoroutine(SpawnCoins());


    }

    IEnumerator SpawnCoins()
    {
        
        yield return new WaitForSeconds(coinSpawnTimer);

        Vector3 spawnPosition = new Vector3(Random.Range(-xParam, xParam), -1, Random.Range(-zParam, xParam));

        Instantiate(coinPrefab, spawnPosition, Quaternion.identity);

        StartCoroutine(SpawnCoins());
    }
    
    
}
