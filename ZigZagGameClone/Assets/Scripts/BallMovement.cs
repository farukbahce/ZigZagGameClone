using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Vector3 direction;
    public float speed;
    public FloorSpawner floorSpawnerScript;
    public static bool isDropped;
    public float addSpeed;
    void Start()
    {
        direction = Vector3.forward;
        isDropped = false;
    }

    
    void Update()
    {
        if(transform.position.y <= 0.4f)
        {

            isDropped = true;
        }
        if(isDropped == true)
        {
            return;
        }
        if(Input.GetMouseButtonDown(0))
        {
            if(direction.x == 0)
            {
                direction = Vector3.left;
            }
            else{

                direction = Vector3.forward;
            }
            speed += addSpeed * Time.deltaTime;  
        }
        
    }
    private void FixedUpdate() 
    {
        Vector3 movement = direction * Time.deltaTime * speed;
        transform.position += movement;     
    }
    private void OnCollisionExit(Collision collision) {

        if(collision.gameObject.tag == "Floor")
        {
            Score.score++; 
            collision.gameObject.AddComponent<Rigidbody>(); 
            floorSpawnerScript.floor_spawner();
            StartCoroutine(Floor_Del(collision.gameObject));
        }

        IEnumerator Floor_Del(GameObject WipedFloor)
        {
            yield return new WaitForSeconds(3f);
            Destroy(WipedFloor);
        }
        
    }
}
