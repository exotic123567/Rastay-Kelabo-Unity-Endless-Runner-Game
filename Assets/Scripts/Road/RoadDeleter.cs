using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadDeleter : MonoBehaviour
{
    public float lifetime = 50f; 
    public float speed;
    public GameObject player;
    public float roadLength = 500;
    

    // Start is called before the first frame update
    void Start()
    {
        /*player = GameObject.FindGameObjectWithTag("Player");
        FollowPath followPath = player.GetComponent<FollowPath>();
        speed = followPath.speed;
            
        // Calculate lifetime based on road length and speed
        lifetime = roadLength / speed;
        
        // Log speed and lifetime for debugging
        Debug.Log("Speed: " + speed);
        Debug.Log("Lifetime: " + lifetime);*/
        Invoke("DestroyObject", lifetime);
    }

    // Update is called once per frame
    public void DestroyObject()
    {
        Debug.Log("Road Destroyed");
        Destroy(gameObject);
    }
}
