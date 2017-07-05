using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFall : MonoBehaviour {


    private Rigidbody2D rb;
    private Collider2D coll;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "IceCream")
        {
            rb.velocity = Vector2.zero;
            rb.isKinematic = true;

            coll.isTrigger = false;
            gameObject.tag = "IceCream";            
        }

    }

}
