using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerOfRoads : MonoBehaviour
{
    public GameObject roadObject;
    public GameObject cameraObject;
    public float initialCameraZPos = -4.71f;
    public int lengthOfRoad = 500;
    public int roadsSpawned = 1;

    // Start is called before the first frame update
    void Start()
    {
        roadObject = GameObject.FindGameObjectWithTag("Road");
    }

    // Update is called once per frame
    void Update()
    {
        roadObject = GameObject.FindGameObjectWithTag("Road");
        if (cameraObject.transform.position.z - initialCameraZPos > lengthOfRoad/2)
        {
            spawnroad();
            initialCameraZPos += lengthOfRoad;
        }
    }
    public void spawnroad() {
        GameObject newRoad = Instantiate(roadObject, new Vector3(0, 0, (lengthOfRoad * roadsSpawned)), transform.rotation);
        Debug.Log("New Road Spawned");
        roadsSpawned += 1;
        //newRoad.transform.GetChild(0).gameObject.SetActive(true);
    }
}
