using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingLand : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool isFalling = false;

    void Start()
    {
       
        Invoke("StartFalling", 3f);
    }

    void StartFalling()
    {
        isFalling = true;
        rb.bodyType = RigidbodyType2D.Dynamic;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (isFalling)
        {
            // Land has hit something and should stop falling
            rb.bodyType = RigidbodyType2D.Static;
        }
    }
}

