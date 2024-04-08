using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpAnimation : MonoBehaviour
{
    public float speed;
    public float initialYpos;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 20f, this.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y < initialYpos)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + (speed * Time.deltaTime), this.transform.position.z);
        }
    }
}
