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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  

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
        SceneManager.LoadScene(1);
    }
}
