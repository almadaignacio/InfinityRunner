using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerCrouch : MonoBehaviour
{
    public GameObject Stand;
    public GameObject Crouch;
    public static GameManager gameManager;

    private void Start()
    {
        if(gameManager == null)
        {
            gameManager = FindObjectOfType<GameManager>();
        }
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.S))
        {
            Crouch.SetActive(false);
            Stand.SetActive(true); 
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    { 
        if (collision.gameObject.CompareTag("Obstacle"))
        {  
            gameManager.GameOver();
        }
    }
}
