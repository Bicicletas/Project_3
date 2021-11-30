using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private Rigidbody playerRigidbodey;
    [SerializeField] private float jumpForce = 400f;
    public float gravityModifier = 1f;

    void Start()
    {
        playerRigidbodey = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRigidbodey.AddForce(Vector3.up * jumpForce);
        }
    }
}
