using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonPause : MonoBehaviour
{
    [SerializeField] private GameObject buttonPause;
    [SerializeField] private GameObject MenuPause;

    public void Pause()
    {
        Time.timeScale = 0f;
        buttonPause.SetActive(false);
        MenuPause.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        buttonPause.SetActive(true);
        MenuPause.SetActive(false);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
