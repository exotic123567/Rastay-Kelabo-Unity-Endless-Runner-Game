using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DetectGateAndGivePower : MonoBehaviour
{
    public GameObject bulletSpawner;
    public SpawnBullets spawnBullets;

    public GateStatus gateStatus;
    TextMeshProUGUI textForgate;
    Canvas canvasForText;
    public GameObject ally;
    // Start is called before the first frame update
    void Start()
    {
        bulletSpawner = GameObject.FindGameObjectWithTag("BullSpawn");
        spawnBullets = bulletSpawner.GetComponent<SpawnBullets>();
        gateStatus = this.GetComponent<GateStatus>();
        canvasForText = this.GetComponentInChildren<Canvas>();
        textForgate = canvasForText.GetComponentInChildren<TextMeshProUGUI>();
        ally = GameObject.FindGameObjectWithTag("Ally").transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Gate Triggered");
        if (other.gameObject.tag == "Player")
        {
            if (gateStatus.getcurrentpowerup() == "AmmoIncrease") {
                int number = int.Parse(textForgate.text);
                Debug.Log("Ammo Increase: " + number);
                spawnBullets.increaseAmmo(number);
            }
            else if (gateStatus.getcurrentpowerup() == "RateOfFireIncrease") {
                string numberStr = textForgate.text.Substring(7);
                int number = int.Parse(numberStr);
                Debug.Log("Fire Rate Increase: " + number);
                spawnBullets.increaseRateOfFire(number);
            }
            else if (gateStatus.getcurrentpowerup() == "ScoreMultiplier") {
                string numberStr = textForgate.text.Substring(7);
                int number = int.Parse(numberStr);
                Debug.Log("Score Multiplier: " + number);
                ScoreLogicScript scoreLogicScript = other.GetComponent<ScoreLogicScript>();
                scoreLogicScript.updateMultiplier(number);
            }
            else if (gateStatus.getcurrentpowerup() == "Ally") {
                ally.SetActive(true);
                Debug.Log("Ally Spawned");
            }
        }
    }
}
