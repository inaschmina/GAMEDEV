using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;
 

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, Random.Range(0.0f, 1.5f));
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int prefabIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[prefabIndex], spawnPos, animalPrefabs[prefabIndex].transform.rotation);
    }
}
