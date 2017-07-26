using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraneMove : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;
    private bool GoRight = true;
    private bool GoLeft = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 Vel = new Vector2(1.0f, 0.0f);

        if (GoRight)
        {
            rb.velocity = Vel * speed;

        }

        if (GoLeft)
        {
            rb.velocity = Vel * -speed;
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
}
