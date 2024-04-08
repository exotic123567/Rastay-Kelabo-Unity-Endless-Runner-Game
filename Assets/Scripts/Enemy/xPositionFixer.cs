using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xPositionFixer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x < -1.53f)
        {
            this.transform.position = new Vector3(-1.53f, this.transform.position.y, this.transform.position.z);
        }
        if (this.transform.position.x > 1.53f)
        {
            this.transform.position = new Vector3(1.53f, this.transform.position.y, this.transform.position.z);
        }
    }
}
