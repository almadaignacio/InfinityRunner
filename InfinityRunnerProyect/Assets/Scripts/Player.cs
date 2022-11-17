using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Stand;
    public GameObject Crouch;
    public int fuerzaDeSalto = 5;
    public bool isJumping;
    Rigidbody2D rb;
    public Animator playerAnimator;

    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        isJumping = false;
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isJumping == false)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, fuerzaDeSalto, 0);
            isJumping = true;
            playerAnimator.SetTrigger("Jp");
        }

        if (Input.GetKeyDown(KeyCode.S) && isJumping == true)
        {
            //GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
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
            //Time.timeScale = 0;    
            gameManager.GameOver();
        }
    }

    private void OnTrigerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Obstacle")
        {
            gameManager.GameOver();
        }
    }
}
