using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    // public Transform[] spawnPoints;
    public GameObject obstaclePrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;
    public Vector3 spawnPos = new Vector3(0, 0, 1);

    public float spawnInterval = 8.0f;
    // public float Count;

    void Start()
    {
        StartCoroutine(ObstacleWave());
        StartCoroutine(IntervalWave());
    }
        
    void Update()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
      
        // if (Time.time > Count)
        // {
        //     Instantiate(obstaclePrefab, transform.position, Quaternion.identity);
        //     Count = Time.time + SpawnInterval;
        // }

    }

    void SpawnObstacle()
    {
        // int randObstacle = Random.Range(0, obstaclePrefab.Length);
        // int randSpawPoint = Random.Range(0, spawnPoints.Length);
        spawnPos = new Vector3(screenBounds.x + 5, Random.Range(-1.5f, 1.5f), 1);
        GameObject obj = Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);
    }

    IEnumerator ObstacleWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            SpawnObstacle();
        }
    }

    void SpawInterval()
    {
        if (spawnInterval > 1.0f)
        {
            spawnInterval -= 0.5f;
        }
    }

    IEnumerator IntervalWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(8);
            SpawInterval();
        }
    }

}
