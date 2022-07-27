using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform ball_position;
    Vector3 gap;
    void Start()
    {
        gap = transform.position - ball_position.position;
        
    }

    
    void Update()
    {
        if(BallMovement.isDropped == false)
        {
            transform.position = ball_position.position + gap;
        } 
        
    }
}
