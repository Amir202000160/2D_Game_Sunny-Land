using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ladder : MonoBehaviour
{
    
    public float climbSpeed = 5f;
    private bool isClimbing=false;
 [SerializeField] private Rigidbody2D RB;

   
   



    private void Update()
    {
        


        if (isClimbing)
        {
            Debug.Log("true");

            float moveUD = Input.GetAxisRaw("Vertical");
            RB.velocity = new Vector2(RB.velocity.x, RB.velocity.y);
            if (moveUD > 0)
            {
               
                RB.velocity = new Vector2(RB.velocity.x, 5f);
                
            }
            else if (moveUD < 0)
            {
                RB.velocity = new Vector2(RB.velocity.x, 0);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
          
            isClimbing = true;
            
          
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
          

            isClimbing = false;
            RB.gravityScale = 1f;
        }
    }
}
