using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnBullets : MonoBehaviour
{
    public GameObject bullet;
    public float spawnrate = 0.1f;
    private float timer = 0f;
    public GameObject player;
    public TextMeshProUGUI ammoCt;
    public int bulletsAvailable = 1000;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //Debug.Log("Timer: " + timer + ", Spawn Rate: " + spawnrate);

        if (timer >= spawnrate && bulletsAvailable > 0)
        {
            // Spawn the bullet and reset the timer
            spawnpipe();
            timer = 0;
        }
    }
    void spawnpipe()
    {
        Instantiate(bullet, new Vector3(player.transform.position.x + 0.088f,player.transform.position.y + 1.46f, player.transform.position.z), Quaternion.identity);
        bulletsAvailable -= 1;
        ammoCt.text = bulletsAvailable.ToString();
    }
    public void stopSpawning()
    {
        spawnrate = 1000;
    }
    public void increaseAmmo(int amount)
    {
        bulletsAvailable += amount;
        ammoCt.text = bulletsAvailable.ToString();
    }
    public void increaseRateOfFire(int amount)
    { 
        if (spawnrate > 0.01f) {
            spawnrate = spawnrate - (amount * 0.01f);
        }
        Debug.Log("Spawn Rate: " + spawnrate);
    }
}
