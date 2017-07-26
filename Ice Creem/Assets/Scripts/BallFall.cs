using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallFall : MonoBehaviour
{
    public PhysicsMaterial2D ExMaterial;
    public GameObject LastBall;

    private GameObject Excellent;
    private bool ex1 = false, ex2 = false, excellent = false;
    private bool DontIceCream = true;
    private Collider2D coll;
    private Rigidbody2D rb;

    private void Start()
    {
        LastBall = GameObject.Find("Start");      

        coll = GetComponent<Collider2D>();
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
        }
                
    }

    private void Update()
    {
        if (excellent && DontIceCream)
        {
            rb.velocity = Vector2.zero;
            coll.sharedMaterial = ExMaterial;

            //gameObject.AddComponent<FixedJoint2D>();
            //FixedJoint2D fixedJoint = GetComponent<FixedJoint2D>();
            //fixedJoint.connectedBody = LastBall.GetComponent<Rigidbody2D>();

            Excellent.transform.position = gameObject.transform.position - new Vector3(0.0f, 0.0538f, 0.0f);

            DontIceCream = false;
        }
    }
}

