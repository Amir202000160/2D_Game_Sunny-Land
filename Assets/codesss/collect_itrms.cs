using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collect_itrms : MonoBehaviour
{
    private int cherry= 0;
    [SerializeField] private Text cherrytext;
    AudioSource item;
    private void Start()
    {
        item = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("COLLECTABLE_ITEMS")){
            item.Play();
            Destroy(collision.gameObject);
            cherry++;
            cherrytext.text = "CHERRIES:" + cherry;
            
        }
        
    }
}
