using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraneMove : MonoBehaviour
{
    public float speed;

    private bool qwer = false;
    private float time;
    private Rigidbody2D rb;
    private bool GoRight = true;
    private bool GoLeft = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 Vel = new Vector2(1.0f, rb.velocity.y);

        if (GoRight)
        {
            rb.velocity = Vel * speed;

        }

        if (GoLeft)
        {
            rb.velocity = Vel * -speed;
        }

        if (qwer)
        {
            rb.velocity = new Vector2(rb.velocity.x, 1.0f);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.name == "LeftBound")
        {
            GoRight = true;
            GoLeft = false;
        }

        if (collision.name == "RightBound")
        {
            GoRight = false;
            GoLeft = true;
        }
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            qwer = true;
            time = Time.time;
        }

        if (Time.time - time >= 1.0f)
        {
            qwer = false;
            rb.velocity = new Vector2(rb.velocity.x, 0.0f);
        }
    } 
}
