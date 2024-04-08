using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayDeathAnimation : MonoBehaviour
{
    public Animator animationController;
    public GameObject enemy;
    public GameObject player;
    void Start() {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        player = GameObject.FindGameObjectWithTag("Player"); 
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.z - enemy.transform.position.z <=50 ) {
            animationController.SetBool("playDeathAnim", true);
        }
    }
}
