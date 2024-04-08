using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootCrateDrop : MonoBehaviour
{
    public GameObject bulletspawner;
    public GameObject player;
    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        bulletspawner = GameObject.FindGameObjectWithTag("BullSpawn");
        player = GameObject.FindGameObjectWithTag("ParentPlayer");
    }
    public void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 5f)
        {
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            bulletspawner.GetComponent<SpawnBullets>().increaseAmmo(Random.Range(10, 100));
            Destroy(gameObject);
        }
    }
}
