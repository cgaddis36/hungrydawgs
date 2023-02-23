using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2.0f;
    private float rightDelay = 3.0f;
    private float leftDelay = 3.0f;

    private float spawnInterval = 1.5f;
    void Start()
    {
      InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
      InvokeRepeating("SpawnRightAnimal", rightDelay, spawnInterval);
      InvokeRepeating("SpawnLeftAnimal", leftDelay, spawnInterval);

    }

    void Update()
    {
    }
    void SpawnRandomAnimal() {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos,
        animalPrefabs[animalIndex].transform.rotation);
    }
     void SpawnRightAnimal() {
        Vector3 spawnPos = new Vector3(20, 0, Random.Range(8, 15));
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos,
        Quaternion.Euler(animalPrefabs[animalIndex].transform.rotation.x, 
        -90, 
        animalPrefabs[animalIndex].transform.rotation.z));
    }
      void SpawnLeftAnimal() {
        Vector3 spawnPos = new Vector3(-20, 0, Random.Range(8, 15));
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos,
        Quaternion.Euler(animalPrefabs[animalIndex].transform.rotation.x, 
        90, 
        animalPrefabs[animalIndex].transform.rotation.z));
    }
}
