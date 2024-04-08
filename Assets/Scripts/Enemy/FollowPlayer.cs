using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public float speed = 20;
    float distanceTravelled=0;
    public GameObject enemyObject;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        /*if (transform.position.z - player.transform.position.z <= 0)
        {
            Destroy(transform.parent.gameObject);
        }*/
        distanceTravelled = speed * Time.deltaTime;
        Vector3 currentPosition = this.transform.position;
        currentPosition.z += distanceTravelled;
        transform.position = currentPosition;
        /*Vector3 enemyObjectPos = this.transform.position;
        enemyObjectPos.x = 0;
        this.transform.position = enemyObjectPos;*/ 
    }
    /*void StartMoveAnimation() {
        Animator animator = this.GetComponent<Animator>();
        animator.runtimeAnimatorController = newController;
    }*/
}
