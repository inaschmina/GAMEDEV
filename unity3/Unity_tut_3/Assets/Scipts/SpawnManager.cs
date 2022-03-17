using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    private PlayerController controller;
    private Vector3 spawnPosition = new Vector3(25, 0, 0);
    private float startDelay = 2;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnObstacle", startDelay);
        controller = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    void SpawnObstacle()
    {
        if (controller.gameOver == false)
        {
            int prefabIndex = Random.Range(0, obstaclePrefab.Length);
            Instantiate(obstaclePrefab[prefabIndex], spawnPosition, obstaclePrefab[prefabIndex].transform.rotation);
            Invoke("SpawnObstacle", Random.Range(1.0f, 3.0f));
        }
    }
}
