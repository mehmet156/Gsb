using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
     float yAxis;
    void Start()
    {
        InvokeRepeating("SpawnEnemy",1,3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnEnemy()
    {
        yAxis= Random.Range(1.7f,5);
        Instantiate(enemy,new Vector3(25,yAxis,0),Quaternion.identity);
    }
}
