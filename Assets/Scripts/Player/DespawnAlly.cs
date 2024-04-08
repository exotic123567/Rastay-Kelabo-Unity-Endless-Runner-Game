using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnAlly : MonoBehaviour
{
    public float timer = 0f;
    public GameObject ally;
    // Start is called before the first frame update
    void Start()
    {
        ally = GameObject.FindGameObjectWithTag("Ally").transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 10f)
        {
            timer = 0;
            ally.SetActive(false);
        }
    }
}
