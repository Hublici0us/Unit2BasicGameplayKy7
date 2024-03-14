using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    // [] represents an array, where you can store multiple variables in.

    float spawnX = 20;
    float spawnZ = 30;
    public float spawnDelay = 2;
    public float spawnInterval = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimals", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnAnimals()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnX, spawnX), 0, spawnZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
