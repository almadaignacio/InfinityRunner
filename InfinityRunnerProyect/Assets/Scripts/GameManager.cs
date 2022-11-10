using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject GOpanel;
    public GameObject bottonPause;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        GOpanel.SetActive(true);
        bottonPause.SetActive(false);
    }
    
    public void RestarGame()
    {
        SceneManager.LoadScene("Game");
    }
}
