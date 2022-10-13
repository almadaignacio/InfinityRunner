using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
     float tiempoVivo;
     float tiempoMaximoDeVida;
    //public float velocidad = 3f;

    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    public GameObject obstacle4;
    public GameObject obstacle5;
    public GameObject obstacle6;
    public GameObject obstacle7;

    int chooseObstacle;

    // Start is called before the first frame update
    void Start()
    {
        tiempoMaximoDeVida = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position -= new Vector3(velocidad * (Time.deltaTime), 0, 0);
        tiempoVivo += Time.deltaTime;

        if (tiempoVivo >= tiempoMaximoDeVida)
        {
            GenerateObstacles();
            tiempoVivo = 0;
            //Destroy(this.gameObject);
        }
    }

    void GenerateObstacles()
    {
        //GameObject newObstable = Instantiate(obstacle1);

        chooseObstacle = Random.Range(1, 8);
        if(chooseObstacle == 1) { GameObject newObstable = Instantiate(obstacle1);}
        if (chooseObstacle == 2) { GameObject newObstable = Instantiate(obstacle2); }
        if (chooseObstacle == 3) { GameObject newObstable = Instantiate(obstacle3); }
        if (chooseObstacle == 4) { GameObject newObstable = Instantiate(obstacle4); }
        if (chooseObstacle == 5) { GameObject newObstable = Instantiate(obstacle5); }
        if (chooseObstacle == 6) { GameObject newObstable = Instantiate(obstacle6); }
        if (chooseObstacle == 7) { GameObject newObstable = Instantiate(obstacle7); }
    }
}
