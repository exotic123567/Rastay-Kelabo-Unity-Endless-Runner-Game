using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentSpawner : MonoBehaviour
{
    public GameObject envObject;
    public GameObject player;
    public int envspawned = 1;
    public float envdistance = 60;
    public float timer = 0;
    public float endOfEnvDistance1;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        /*if (player.transform.position.z == (60 * (envspawned - 1))+ 30)
        {
            spawnenv();
        }*/
        if (timer >= 2.5f)
        {
            spawnenv();
            timer = 0;
        }
    }
    public void spawnenv() {
        GameObject env = Instantiate(envObject, new Vector3(envObject.transform.position.x, envObject.transform.position.y, (envspawned * envdistance) + endOfEnvDistance1), Quaternion.identity);
        envspawned += 1;
    }
}
