using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DeleteBullets : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z - player.transform.position.z > 250)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Bullet collided with: " + other.gameObject.name);
        // Check if the bullet collides with an enemy
        Destroy(gameObject);
    }
    
}
