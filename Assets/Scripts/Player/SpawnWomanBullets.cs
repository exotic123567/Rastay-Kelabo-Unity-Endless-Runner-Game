using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWomanBullets : MonoBehaviour
{
    public GameObject bullet;
    public float spawnrate = 0.1f;
    private float timer = 0f;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("WomanPlayer");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //Debug.Log("Timer: " + timer + ", Spawn Rate: " + spawnrate);

        if (timer >= spawnrate )
        {
            // Spawn the bullet and reset the timer
            spawnpipe();
            timer = 0;
        }
    }
    void spawnpipe()
    {
        Debug.Log("Woman Spawned a Bullet");
        Instantiate(bullet, new Vector3(player.transform.position.x + 0.088f,player.transform.position.y + 1.46f, player.transform.position.z), Quaternion.identity);
    }
    public void stopSpawning()
    {
        spawnrate = 1000;
    }
    
    public void increaseRateOfFire(int amount)
    { 
        if (spawnrate > 0.01f) {
            spawnrate = spawnrate - (amount * 0.01f);
        }
        Debug.Log("Spawn Rate: " + spawnrate);
    }
}
