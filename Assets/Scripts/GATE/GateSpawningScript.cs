using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GateSpawningScript : MonoBehaviour
{
    public GameObject gateObject;
    public GameObject player;
    public int gap = 100;
    public int init_gap = 100;
    public int gatespawned = 0;
    public float timer = 0;

    public string[] powerUps = {
        "AmmoIncrease",
        "RateOfFireIncrease",
        "ScoreMultiplier",
        "Ally"
    };

    private Dictionary<string, string> powerUpEffects = new Dictionary<string, string>()
    {
        { "AmmoIncrease", "Ammo +" },
        { "RateOfFireIncrease", "Speed +" },
        { "ScoreMultiplier", "Score x" },
        { "Ally", "+1 Ally!" }
    };

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        spawngate();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 5f)
        {
            spawngate();
        }
    }

    public void spawngate()
    {
        string selectedPowerUp1 = powerUps[Random.Range(0, powerUps.Length)];
        string selectedPowerUp2 = powerUps[Random.Range(0, powerUps.Length)];

        string effect1 = GetRandomPowerUpEffect(selectedPowerUp1);
        string effect2 = GetRandomPowerUpEffect(selectedPowerUp2);

        // Spawn the gate prefab at a random X position
        GameObject gatePrefab = Instantiate(gateObject, new Vector3(gateObject.transform.position.x, gateObject.transform.position.y, (gap * gatespawned) + init_gap), Quaternion.identity);

        Transform[] children = gatePrefab.GetComponentsInChildren<Transform>();

        foreach (Transform child in children)
        {
            if (child.CompareTag("Gate"))
            {
                Canvas canvas = child.GetComponentInChildren<Canvas>();
                TextMeshProUGUI text = canvas.GetComponentInChildren<TextMeshProUGUI>();

                if (child.name == "LeftGate")
                {
                    text.text = effect1;
                    child.GetComponent<GateStatus>().setPowerUp(selectedPowerUp1);
                }
                else if (child.name == "RightGate")
                {
                    text.text = effect2;
                    child.GetComponent<GateStatus>().setPowerUp(selectedPowerUp2);
                }
            }
        }

        timer = 0;
        gatespawned += 1;
    }

    private string GetRandomPowerUpEffect(string powerUp)
    {
        if (powerUpEffects.ContainsKey(powerUp))
        {
            if (powerUp == "AmmoIncrease")
            {
                return powerUpEffects[powerUp] + Random.Range(10, 50).ToString();
            }
            else if (powerUp == "RateOfFireIncrease")
            {
                return powerUpEffects[powerUp] + Random.Range(1, 5).ToString();
            }
            else if (powerUp == "ScoreMultiplier")
            {
                return powerUpEffects[powerUp] + Random.Range(2, 5).ToString();
            }
            else if (powerUp == "Ally")
            {
                return powerUpEffects[powerUp];
            }
        }
        throw new KeyNotFoundException("Power-up effect not found for: " + powerUp);
    }
}
