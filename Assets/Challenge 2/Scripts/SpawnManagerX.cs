using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnIntervalMin = 3f;
    private float spawnIntervalMax = 5f;
    private float randomInterval;

    // Start is called before the first frame update
    private void Start()
    {
        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    private void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        int randomBall = Random.Range(0, ballPrefabs.Length);
        Instantiate(ballPrefabs[randomBall], spawnPos, ballPrefabs[randomBall].transform.rotation);

        randomInterval = Random.Range(spawnIntervalMin, spawnIntervalMax);
        Invoke("SpawnRandomBall", randomInterval);

        //debug
        //Debug.Log(randomInterval);
    }
}