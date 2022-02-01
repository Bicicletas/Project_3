using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    using Random = UnityEngine.Random;

public class PlayerControler : MonoBehaviour
{
    private Rigidbody playerRigidbodey;
    [SerializeField] private float jumpForce = 400f;
    public float gravityModifier = 1f;
    private bool isOnTheGround = true;
    private bool isSecondJump = true;
    public bool gameOver;
    private Animator playerAnimator;
    public ParticleSystem Explosion;
    public ParticleSystem Dirt;


    void Start()
    {
        gameOver = false;
        playerRigidbodey = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        playerAnimator = GetComponent<Animator>();
    }
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && isOnTheGround && !gameOver)
        {
            playerRigidbodey.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnTheGround = false;
            playerAnimator.SetTrigger("Jump_trig");
            Dirt.Stop();
            isSecondJump = false;
        }
        if (Input.GetKeyDown(KeyCode.W) && !isOnTheGround && !gameOver && !isSecondJump)
        {

            playerRigidbodey.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            //playerAnimator.SetTrigger("Jump_trig");
            isSecondJump = true;
        }



    }

    private void OnCollisionEnter(Collision otherCollider)
    {
        if (!gameOver)
        {
            if (otherCollider.gameObject.CompareTag("Ground"))
            {
                isOnTheGround = true;

            }

            if (otherCollider.gameObject.CompareTag("Obstacle"))
            {
                gameOver = true;
                int deathType = Random.Range(1, 3);
                playerAnimator.SetBool("Death_b", true);
                playerAnimator.SetInteger("DeathType_int", deathType);
                Vector3 offset = new Vector3(0, 1.5f, 0);
                Instantiate(Explosion, transform.position + offset, Explosion.transform.rotation);
                Explosion.Play();
                Dirt.Stop();
            }
        }
        

    }


}
