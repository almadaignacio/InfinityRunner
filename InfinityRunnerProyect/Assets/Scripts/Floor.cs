using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{

    //public float offsetX = 26;
    public float speed;
    public float start;
    public float end;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);

        if (transform.position.x <= end)

            if (gameObject.tag == "Obstacle")
        {
            Destroy(gameObject);
        }
        else
        {
            transform.position = new Vector2(start, transform.position.y);
        }
        
        /*
        transform.position -= new Vector3(6 * Time.deltaTime, 0, 0);

        if (transform.position.x <= -offsetX)
        {
            transform.position = new Vector3(offsetX, transform.position.y, 0);
        }
        */
    }
}
