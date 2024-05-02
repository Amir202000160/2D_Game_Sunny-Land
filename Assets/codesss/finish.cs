using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    private AudioSource finishSound;
    private SpriteRenderer sr;
    [SerializeField] float delayTime = 3;

    private void Start()
    {
        finishSound= GetComponent<AudioSource>();
        sr= GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name== "player")
        {
            finishSound.Play();
          
            StartCoroutine(DelayedSceneLoad(delayTime));

        }

    }
    IEnumerator DelayedSceneLoad(float delayTime)
    {
        sr.enabled = false;
        yield return new WaitForSeconds(delayTime);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
