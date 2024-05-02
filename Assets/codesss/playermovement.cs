using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class playermovement : MonoBehaviour
{
    private Rigidbody2D RB ;
    private SpriteRenderer SP;
    private Animator Ani;
    private BoxCollider2D coll;
    [SerializeField] private LayerMask J_ground;
    [SerializeField] private float jumb;
    [SerializeField] private float moveLR;

    

    private enum MoveState { idle , run , jump , fall , couch }
     // Start is called before the first frame update
     private void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        Ani = GetComponent<Animator>(); 
        SP = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        transform.rotation=Quaternion.Euler(0f,0f,0f);

        //player_movement-------------------

        MoveState STATE;

        // JUMP----------------

        if (Input.GetButtonDown("Jump") && Isground())
        {
            RB.velocity = new Vector2( RB.velocity.x , 5f );
        }
        // MOVE LEFT AND RIGHT--------------

        moveLR= Input.GetAxisRaw("Horizontal");
        RB.velocity = new Vector2(moveLR*7F, RB.velocity.y);
         if (moveLR > 0)
        { STATE = MoveState.run;
            SP.flipX = false;

        }
         else if (moveLR < 0)
        {
            STATE = MoveState.run;
            SP.flipX = true;
        }
         else 
                { STATE = MoveState.idle; }
        if (RB.velocity.y > .1f)
        {
            STATE = MoveState.jump;
        }
        else if (RB.velocity.y < -.1f)
        {
            STATE = MoveState.fall;
        }
        // MOVE UP AND DOWN ------------------
        
        
           float moveUD = Input.GetAxisRaw("Vertical");
            RB.velocity = new Vector2(RB.velocity.x, RB.velocity.y);
            if (moveUD < 0)
            {
                STATE = MoveState.couch;
            RB.velocity = new Vector2(RB.velocity.x, -5f);
        }
            
        
        
        Ani.SetInteger("STATE", (int)STATE);

    }
    private bool Isground()
    {
       return  Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, J_ground);
    }
}
