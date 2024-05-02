using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class enemy_movement : MonoBehaviour
    {

    [SerializeField] private GameObject[] waypoints;
    private int currentwayponit = 0;

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(waypoints[currentwayponit].transform.position, transform.position) < .1f)
        {

            currentwayponit++;
            if (currentwayponit >= waypoints.Length)
            {
                currentwayponit = 0;


            }
            // Flip the enemy sprite depending on the direction of movement
            if (waypoints[currentwayponit].transform.position.x > transform.position.x)
            {
                transform.localScale = new Vector3(-0.5f, 0.5f, 0.5f); // Flip the sprite horizontally
            }
            else
            {
                transform.localScale = new Vector3(0.5f, 0.5f, 0.5f); // Reset the sprite orientation
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentwayponit].transform.position, Time.deltaTime * 4f);



    }
}

    

