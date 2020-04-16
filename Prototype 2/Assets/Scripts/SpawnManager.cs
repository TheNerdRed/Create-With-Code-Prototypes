using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float spawnRangeX = 16f;
    private float spawnPosZ = 16f;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called at the beginning
    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void SpawnRandomAnimal()
    {
        // Generates a random spawn position for the animals
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        // Generates a random number between 0 - 2 (for a random animal)
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        // Spawns a new instance of a random animal
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

    } // end SpawnRandomAnimal
}
