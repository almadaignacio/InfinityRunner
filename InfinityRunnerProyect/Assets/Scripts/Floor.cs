using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public float speed;
    public float start;
    public float end;

    void Update()
    {
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);

        if (transform.position.x <= end)
        {
            transform.position = new Vector2(start, transform.position.y);
        } 
    }
}
