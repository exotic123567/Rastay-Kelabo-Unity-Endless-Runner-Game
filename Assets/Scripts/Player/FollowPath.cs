using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    public float speed = 20;
    float distanceTravelled=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distanceTravelled += speed * Time.deltaTime;
        Vector3 currentPosition = this.transform.position;
        currentPosition.z = distanceTravelled;
        transform.position = currentPosition;   
    }
    public void setSpeedToZero() {
        speed = 0;
    }
}
