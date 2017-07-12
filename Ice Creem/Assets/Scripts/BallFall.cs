using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFall : MonoBehaviour
{
    private GameObject Excellent;
    private bool ex1 = false, ex2 = false, excellent = false;
    private bool DontIceCream = true;
    private Rigidbody2D rb;

    private void Start()
    {
        Excellent = GameObject.Find("Excellent");
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (DontIceCream && collision.name == "Ex1")
        {
            ex1 = true;
        }

        if (DontIceCream && collision.name == "Ex2")
        {
            ex2 = true;
        }

        if (DontIceCream && ex2 && ex1)
        {
            excellent = true;
            DontIceCream = false;
        }


    }

    private void Update()
    {
        if (excellent)
        {
            rb.velocity = Vector2.zero;
            Excellent.transform.position = gameObject.transform.position;


        }
    }
}
