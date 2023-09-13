using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject Stand;
    [SerializeField] private GameObject Crouch;
    [SerializeField] private int jump = 5;
    private bool isJumping;
    Rigidbody2D rb;
    Animator playerAnimator;
    GameManager gameManager;

    void Start()
    {
        if (gameManager == null)
        {
            gameManager = FindObjectOfType<GameManager>();
        }
        isJumping = false;
        rb = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isJumping == false)
        {
            rb.velocity = new Vector3(0, jump, 0);
            isJumping = true;
            playerAnimator.SetTrigger("Jp");
        }

        if (Input.GetKeyDown(KeyCode.S) && isJumping == true)
        {
            Crouch.SetActive(false);
        }

        if (Input.GetKey(KeyCode.S) && isJumping == false)
        {
            Crouch.SetActive(true);
            Stand.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Floor"))
        {
            isJumping = false;
            playerAnimator.SetTrigger("Njp");
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameManager.GameOver();
        }
    }
}
