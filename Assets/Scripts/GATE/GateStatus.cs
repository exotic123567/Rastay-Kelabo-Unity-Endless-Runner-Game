using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateStatus : MonoBehaviour
{
    public string[] powerUps = {
        "AmmoIncrease",
        "RateOfFireIncrease",
        "ScoreMultiplier",
        "Invisibility",
        "TimeFreeze",
        "SummonAlly",
        "BombLauncher",
        "EnemySpeedIncrease",
        "ReverseControls",
        "LowerRateOfFire"
    };
    public string currentPowerUp;
    public void setPowerUp(string powerUp) {
        currentPowerUp = powerUp;
    }
    public string getcurrentpowerup() {
        return currentPowerUp;
    }
}
