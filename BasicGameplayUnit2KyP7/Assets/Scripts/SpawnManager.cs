using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    // [] represents an array, where you can store multiple variables in.

    float spawnX = 15;
    float spawnZ = 15;
    public float spawnDelay = 2;
    public float spawnInterval = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        //invokes the function, with the delay and how often to repeat it.
        InvokeRepeating("SpawnAnimals", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnAnimals()
        //spawns the animals
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosVert = new Vector3(Random.Range(-spawnX, spawnX), 0, spawnZ);
        Vector3 spawnPosHorz1 = new Vector3(spawnX, 0, Random.Range(-spawnZ, spawnZ));
        Vector3 spawnPosHorz2 = new Vector3(-spawnX, 0, Random.Range(-spawnZ, spawnZ));

        Instantiate(animalPrefabs[animalIndex], spawnPosVert, animalPrefabs[animalIndex].transform.rotation);
        Instantiate(animalPrefabs[animalIndex], spawnPosHorz1,transform.rotation);
        Instantiate(animalPrefabs[animalIndex], spawnPosHorz2, animalPrefabs[animalIndex].transform.rotation);
    }
}
