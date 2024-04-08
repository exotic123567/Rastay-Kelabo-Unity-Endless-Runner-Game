using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreLogicScript : MonoBehaviour
{
    private const string HighScoreKey = "HighScore";
    public TextMeshProUGUI highScoreText;
    public int score = 0;
    public TextMeshProUGUI textMeshProUGUI;
    public int multiplier = 1;
    void Start()
    {
        CheckAndUpdateHighScore();
    }
    public void updateMultiplier(int mult)
    {
        multiplier = mult;
    }

    public void UpdateScore(int sc)
    {
        score += multiplier * sc;
        if (textMeshProUGUI != null)
        {
            textMeshProUGUI.text = score.ToString();
        }
        // Update the score
        Debug.Log("Score: " + score);
        CheckAndUpdateHighScore();
    }
    private void CheckAndUpdateHighScore()
    {
        int highScore = PlayerPrefs.GetInt(HighScoreKey, 0);
        if (score > highScore)
        {
            PlayerPrefs.SetInt(HighScoreKey, score);
            PlayerPrefs.Save();
        }
        highScore = PlayerPrefs.GetInt(HighScoreKey, 0);
        Debug.Log("High Score: " + highScore);
        highScoreText.text = "High Score : " + highScore.ToString();
    }
}
