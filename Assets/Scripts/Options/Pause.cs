using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject musician;
    void Start() {
        musician = GameObject.FindGameObjectWithTag("MusicPlayer");
    }
    public void PauseGame() {
        pausePanel.SetActive(true);
        musician.GetComponent<MusicPlayer>().pauseBGM();
        Time.timeScale = 0;
    }
    public void ResumeGame() {
        pausePanel.SetActive(false);
        musician.GetComponent<MusicPlayer>().playBGM();
        Time.timeScale = 1;
    }
    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void QuitToMainMenu() {
        SceneManager.LoadScene(0);
    }
}
