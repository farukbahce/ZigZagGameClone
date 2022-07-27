using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    public GameObject last_floor; 
    
    
    void Start()
    {
        for(int i = 0; i<15; i++)
        {
            floor_spawner();
           
        }
    }
    public void floor_spawner()
    {
        Vector3 direction;
        if(Random.Range(0,2) == 0)
        {
            direction = Vector3.left;
        }
        else
        {
            direction = Vector3.forward;
        }
        last_floor = Instantiate(last_floor,last_floor.transform.position + direction, last_floor.transform.rotation);
        
    }
}
