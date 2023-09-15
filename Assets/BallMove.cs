using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    private Bounce bounce;
    private Rigidbody2D rb;
    Vector2 velocity;
    private Vector2 initialVelocity;
    [SerializeField] private float speed = 30f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        initialVelocity = new Vector2(20f * speed, 5f * speed);
        rb.AddForce(initialVelocity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            ResetPosition(1f);
        }
        else if (collision.gameObject.CompareTag("Player2"))
        {
            ResetPosition(-1f);
        }
    }

    public void ResetPosition(float directionX)
    {
        transform.position = Vector3.zero;
        velocity = new Vector2(directionX, 1f).normalized * speed;

        
        bounce.isBouncingEnabled = false;

        rb.velocity = initialVelocity;

        
        StartCoroutine(EnableBouncingAfterDelay(0.5f));
    }

    private IEnumerator EnableBouncingAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        
        bounce.isBouncingEnabled = true;
    }

}
    
   

