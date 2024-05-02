using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class player_die : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D RB;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        RB = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("trap"))
        {
            Die();
           
        }
    }
    private void Die()
    {
        RB.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("die");
    }
    private void Restartlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
