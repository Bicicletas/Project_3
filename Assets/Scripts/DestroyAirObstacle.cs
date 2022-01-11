using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAirObstacle : MonoBehaviour
{
    public GameObject Explosion;
    public GameObject AirObstacle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("AirObstacle"))
        {
            Instantiate(Explosion, otherCollider.gameObject.transform.position, otherCollider.gameObject.transform.rotation);
            Destroy(otherCollider.gameObject);
            Destroy(Explosion, 1f);
        }
    }
}
