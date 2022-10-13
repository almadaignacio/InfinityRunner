using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Text HiScoreText;
    int score;
    Text scoreText;   

    float Timer;
    float maxTime;

    // Start is called before the first frame update
    void Start()
    {
        HiScoreText.text = "HI   " + PlayerPrefs.GetInt("highscore", 0).ToString("00000");
        score = 0;
        scoreText = GetComponent<Text>();
        maxTime = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if(Timer >= maxTime)
        {
            score++;
            scoreText.text = score.ToString("00000");
            Timer = 0;
        }

        if(Time.timeScale == 0)
        {
            if(score > PlayerPrefs.GetInt("highscore", 0))
            {
                PlayerPrefs.SetInt("highscore", score);
                HiScoreText.text = "HI   " + PlayerPrefs.GetInt("highscore", 0).ToString("00000");
            }

        }
    }
}
