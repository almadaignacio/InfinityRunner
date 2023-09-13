using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject bottonPause;

    void Start()
    {
        Time.timeScale = 1;
    }
    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
        bottonPause.SetActive(false);
    }
    public void RestarGame()
    {
        SceneManager.LoadScene("Game");
    }
}
