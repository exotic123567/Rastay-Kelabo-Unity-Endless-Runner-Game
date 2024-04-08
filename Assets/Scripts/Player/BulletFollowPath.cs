using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFollowPath : MonoBehaviour
{
    public float speed = 20;
    float distanceTravelled=0;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");   
    }

    // Update is called once per frame
    void Update()
    {
        distanceTravelled += speed * Time.deltaTime;
        Vector3 playercurrentPosition = player.transform.position;
        Vector3 currentPosition = this.transform.position;
        currentPosition.z = distanceTravelled + playercurrentPosition.z;
        transform.position = currentPosition;   
    }
}
