using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject obstacle;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float randomSpawn = 1f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObstacle", 1, Random.Range(randomSpawn, 2*randomSpawn));
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void spawnObstacle()
    {
        Instantiate(obstacle, spawnPos, obstacle.transform.rotation);
    }
}
