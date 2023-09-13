using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    float timeAlive;
    [SerializeField] private float timeMax;
    public Transform origin;

    void Update()
    {
        timeAlive += Time.deltaTime;

        if (timeAlive >= timeMax)
        {
            timeAlive = 0;
            GameObject prefab = ObjectPool.Instance.GetPooledObject();
            if (prefab != null)
            {
                prefab.transform.position = origin.transform.position;
                prefab.transform.rotation = origin.transform.rotation;
                prefab.SetActive(true);
            }
        }
    }
}
