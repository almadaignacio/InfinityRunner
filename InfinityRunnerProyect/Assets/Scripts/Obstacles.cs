using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public float tiempoVivo = 0f;
    public float tiempoMaximoDeVida = 5f;
    public float velocidad = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(velocidad * (Time.deltaTime), 0, 0);
        tiempoVivo += Time.deltaTime;

        if (tiempoVivo >= tiempoMaximoDeVida)
        {
            Destroy(this.gameObject);
        }
    }
}
