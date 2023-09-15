using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Bounce : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool isBouncingEnabled = true;

    Vector3 lastVelocity;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        lastVelocity = rb.velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isBouncingEnabled)
        {
            var speed = lastVelocity.magnitude;
            var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);

            rb.velocity = direction * Mathf.Max(speed, 0f);
        }
    }

}
