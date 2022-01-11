using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] obstacle;
    public GameObject airObstacle;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private Vector3 spawnPosAir = new Vector3(15, 10, 0);
    public float startDelay = 2f;
    public float repeatRate = 2f;
    private PlayerControler playerContollerScript;
    private int randomIndex;


    // Start is called before the first frame update
    void Start()
    {
        playerContollerScript = GameObject.Find("Player").GetComponent<PlayerControler>();

        InvokeRepeating("spawnObstacle", startDelay, repeatRate);
        InvokeRepeating("spawnObstacleAir", startDelay+1, repeatRate);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void spawnObstacle()
    {
        randomIndex = Random.Range(0, obstacle.Length);

        if (!playerContollerScript.gameOver)
        {
            Instantiate(obstacle[randomIndex], spawnPos, obstacle[randomIndex].transform.rotation);
        }
    }

    public void spawnObstacleAir()
    {

        if (!playerContollerScript.gameOver)
        {
            Instantiate(airObstacle, spawnPosAir, airObstacle.transform.rotation);
        }
    }

}
