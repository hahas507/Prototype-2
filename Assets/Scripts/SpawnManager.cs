using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] animalPrefabs;

    private float spawnRangeX = 20;
    private float spawnRangeZ = 20;
    private float startDelay = 2f;
    private float spawnInterver = 1.5f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimals", startDelay, spawnInterver);
    }

    private void Update()
    {
    }

    private void SpawnRandomAnimals()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}