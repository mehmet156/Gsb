using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    public float flapForce = 5f; // Z�plama g�c�
    
    [Header("Physics Settings")]
    public Rigidbody2D rb; // Rigidbody2D bile�eni

    private void Start()
    {
        
    }

    private void Update()
    {
        // Oyuncu input'unu kontrol et
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, flapForce);
        }
        if(gameObject.transform.position.y<-10)
        {
            SceneManager.LoadScene(0);
        }

       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
    }


}
