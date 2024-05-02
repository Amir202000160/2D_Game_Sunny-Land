using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collect_gem : MonoBehaviour
{
    private int gem = 0;
    [SerializeField] private Text gemtext;
    AudioSource item_sound;
    private void Start()
    {
        item_sound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("gem"))
        {
            item_sound.Play();
            Destroy(collision.gameObject);
            gem++;
            gemtext.text = "GEM:" + gem;

        }
    }
}
