using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float maxX = -10f;
    void Update()
    {
        if (transform.position.x <= maxX)
        {
            Destroy(gameObject);
        }
    }
}
