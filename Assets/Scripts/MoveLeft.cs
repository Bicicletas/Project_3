using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    public float speed = 5f;

    private PlayerControler playerContollerScript;

    private void Start()
    {
        playerContollerScript = GameObject.Find("Player").GetComponent<PlayerControler>();
    }

    void Update()
    {
        if (!playerContollerScript.gameOver)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}
