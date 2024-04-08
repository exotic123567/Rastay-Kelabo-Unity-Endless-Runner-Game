using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyObject;
    public GameObject player;
    public GameObject portal;
    public int enemyspawned = 0;
    public float timer = 0;
    public float gap = 100;
    public int enemiesToSpawn = 1;
    public int maxEnemies = 10;
    public int health = 10;
    public int tenChecker = 0; // Variable to track the number of enemies defeated by the player
    

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        portal = GameObject.FindGameObjectWithTag("Portal");
        spawnen(0, health);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2.5f)
        {
            for (int i = 0; i < enemiesToSpawn; i++)
            {
                spawnen(Random.Range(-1.53f, 1.53f), health);
            }
            timer = 0;
            if (enemiesToSpawn < maxEnemies)
            {
                enemiesToSpawn += 1;
            }
        }
        if (tenChecker >= 10)
        {
            // Increase the enemy's health by 10
            health += 5;
            tenChecker = 0;
        }
    }

    public void spawnen(float randomValue, int health)
    {
        // Spawn the enemy prefab at a random X position
        GameObject enemyPrefab = Instantiate(enemyObject, new Vector3(randomValue, enemyObject.transform.position.y, enemyObject.transform.position.z), Quaternion.identity);

        // Get the child object with the movement script
        Transform childTransform = enemyPrefab.transform.GetChild(0); // Assuming the child is at index 0

        // Keep the child's relative position to the parent
        Vector3 relativePos = childTransform.localPosition;

        // Set the enemy prefab's (parent) position considering player position and gap
        enemyPrefab.transform.position = player.transform.position + new Vector3(randomValue, 0, gap);

        // Apply the relative position back to the child for movement logic
        childTransform.localPosition = relativePos;

        HealthLogic healthLogic = childTransform.gameObject.GetComponent<HealthLogic>();
        healthLogic.setHealth(health);

        enemyspawned += 1;
    }

    public void stopSpawning()
    {
        timer = 10000;
    }

    public void enemyDefeated()
    {
        tenChecker++;
    }
}
