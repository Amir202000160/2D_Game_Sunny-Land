using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_land : MonoBehaviour
{
   
    [SerializeField] private GameObject[] waypoints;
    [SerializeField] float speed;
    private int currentwayponit = 0;
  
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(waypoints[currentwayponit].transform.position, transform.position)< .1f)
        {
            
            currentwayponit++;
            if (currentwayponit >= waypoints.Length) 
            {
                currentwayponit = 0;
                
                
            }
            
        }
        
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentwayponit].transform.position, Time.deltaTime * speed);


        
    }
}
