using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthLogic : MonoBehaviour
{
    public int health = 10;
    public GameObject player;
    public GameObject scoreObject;
    public GameObject lootcrate;
    public EnemySpawner enemSpawner;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        scoreObject = GameObject.FindGameObjectWithTag("ScoreCounterLogic");
        enemSpawner = GameObject.FindGameObjectWithTag("EnemySpawner").GetComponent<EnemySpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Instantiate(lootcrate, transform.position, Quaternion.identity);
            enemSpawner.tenChecker += 1;
            Destroy(transform.parent.gameObject);
            scoreObject.GetComponent<ScoreLogicScript>().UpdateScore(1);
            
        }
    }
    void OnTriggerEnter(Collider other)
    {
        // Check if the bullet collides with an enemy
        if (other.gameObject.tag == "Bullet")
        {
            health -=1;
        }
    }
    public void setHealth(int newHealth)
    {
        health = newHealth;
    }
}
