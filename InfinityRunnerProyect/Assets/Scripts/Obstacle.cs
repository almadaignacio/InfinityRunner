using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float objectSpeed;
    [SerializeField] private Rigidbody2D rb;

    private void OnEnable()
    {
        rb.velocity = Vector2.left * objectSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            this.gameObject.SetActive(false);
        }
    }
}
