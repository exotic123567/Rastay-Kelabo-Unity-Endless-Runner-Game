using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLost : MonoBehaviour
{
    public FollowPath playerlogic;
    public SpawnBullets bulletlogic;
    public GameObject enemyObject;
    public GameObject player;
    public GameObject bulletspawner;
    public GameObject enemySpawner;
    public float distanceBetweenPAndE;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("ParentPlayer");
        enemyObject = GameObject.FindGameObjectWithTag("Enemy");
        bulletspawner = GameObject.FindGameObjectWithTag("BullSpawn");
        playerlogic = player.GetComponent<FollowPath>();
        bulletlogic = bulletspawner.GetComponent<SpawnBullets>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyObject = GameObject.FindGameObjectWithTag("Enemy");
        enemySpawner = GameObject.FindGameObjectWithTag("EnemySpawner");
        distanceBetweenPAndE = enemyObject.transform.position.z - player.transform.position.z ;
        if (distanceBetweenPAndE <= 0)
        {
            playerlogic.setSpeedToZero();
            bulletlogic.stopSpawning();
            enemySpawner.GetComponent<EnemySpawner>().stopSpawning();
            SceneManager.LoadScene(2);
        }
    }
}
