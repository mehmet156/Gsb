using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharControl : MonoBehaviour
{

    //karakter hýzýný belirler
    public float moveSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //karakteri sað sol yukarý aþaðý yönde hareket ettirir
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

    //karaktere temas eden ve collider componenti olan objeleri algýlar
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //karaktere temas eden algýlanan objeyi yok eder
        Destroy(collision.gameObject);
    }
}
