using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public bool Level;
    public int indexlevel;

    // Update is called once per frame
    void Update()
    {
        if (Level)
        {
            ChangeLevel(indexlevel);
        }
    }

    public void ChangeLevel(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
