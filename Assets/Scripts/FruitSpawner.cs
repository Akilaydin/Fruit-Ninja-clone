using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject fruitPrefab;
    [SerializeField]
    private Transform[] spawnPoints;
    [SerializeField]
    private float minDelay = 0.1f;
    [SerializeField]
    private float MaxDelay = 1f;
    void Start()
    {   
        StartCoroutine(SpawnFruits());
    }

    private IEnumerator SpawnFruits()
    {
        while (true)
        {
            float delay = Random.Range(minDelay,MaxDelay);
            yield return new WaitForSeconds(delay);
            int spawnIndex = Random.Range(0,spawnPoints.Length);
            Transform spawnPoint = spawnPoints[spawnIndex];
            Instantiate(fruitPrefab,spawnPoint.position,spawnPoint.rotation);
        }
    }
}
