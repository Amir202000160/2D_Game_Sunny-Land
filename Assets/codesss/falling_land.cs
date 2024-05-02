using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling_land : MonoBehaviour
{
    public float fallDelay = 2f;
    
    private SpriteRenderer sr;
    void Start()
    {
        // Get a reference to the Rigidbody2D component
        
        sr= GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        // Check if the player collided with this object
        if (col.gameObject.CompareTag("Player"))
        {
            // Invoke the Fall method after the specified delay
            Invoke("Fall", fallDelay);
            
        }
    }

    void Fall()
    {
        // Disable the collider so the player falls through
        GetComponent<Collider2D>().enabled = false;
        sr.enabled = false;

        // Enable gravity on the Rigidbody2D component
       

        // Destroy the object after a short delay to simulate falling
     //   Destroy(gameObject);


    }
}

