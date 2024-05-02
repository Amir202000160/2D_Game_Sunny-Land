using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trampoline : MonoBehaviour
{
    public float bounceForce = 10f;
    public Animator anim;
    

    private void Start()
    {

        anim=GetComponent<Animator>();
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {    
            Rigidbody2D rb = col.gameObject.GetComponent<Rigidbody2D>();
            anim.SetTrigger("jumb");
            if (rb != null)
            {
                Vector2 bounceVector = new Vector2(rb.velocity.x, bounceForce);
                rb.velocity = bounceVector;
                
                
            
        }
        }
    }
}
