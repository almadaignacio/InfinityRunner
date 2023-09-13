using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Text highScoreText;
    public int scoreNumber;
    public Text scoreText;   

    public float timer;
    public float maxTime;

    void Start()
    {
        highScoreText.text = "HI   " + PlayerPrefs.GetInt("highscore", 0).ToString("00000");
        scoreNumber = 0;
        scoreText = GetComponent<Text>();
        maxTime = 0.1f;
    }
    void Update()
    {
        Punctuation();
    }

     private void Punctuation()
    {
        timer += Time.deltaTime;
        if (timer >= maxTime)
        {
            scoreNumber++;
            scoreText.text = scoreNumber.ToString("00000");
            timer = 0;
        }

        if (Time.timeScale == 0)
        {
            if (scoreNumber > PlayerPrefs.GetInt("highscore", 0))
            {
                PlayerPrefs.SetInt("highscore", scoreNumber);
                highScoreText.text = "HI   " + PlayerPrefs.GetInt("highscore", 0).ToString("00000");
            }
        }
    }
}
