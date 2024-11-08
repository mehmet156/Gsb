using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharControl : MonoBehaviour
{

    //karakter h�z�n� belirler
    public float moveSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //karakteri sa� sol yukar� a�a�� y�nde hareket ettirir
        if(Input.GetKey(KeyCode.D)) 
        {
            transform.position = transform.position + Vector3.right * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) )
        {
            transform.position = transform.position + Vector3.left * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) )
        {
            transform.position = transform.position + Vector3.down * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W) )
        {
            transform.position = transform.position + Vector3.up * moveSpeed * Time.deltaTime;
        }

    }

    //karaktere temas eden ve collider componenti olan objeleri alg�lar
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //karaktere temas eden alg�lanan objeyi yok eder
        Destroy(collision.gameObject);
    }
}
