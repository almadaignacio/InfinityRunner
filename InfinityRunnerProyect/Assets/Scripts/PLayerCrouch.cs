using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerCrouch : MonoBehaviour
{
    public GameObject Stand;
    public GameObject Crouch;

    public GameManager gameManager;
    public Animator CrouchAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            CrouchAnimator.SetTrigger("Again");
        }

            if (Input.GetKeyUp(KeyCode.S))
        {
            Crouch.SetActive(false);
            Stand.SetActive(true);
           
        }
    }

    private void OnTrigerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
        {
            gameManager.GameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            //Time.timeScale = 0;    
            gameManager.GameOver();
        }
    }
}
