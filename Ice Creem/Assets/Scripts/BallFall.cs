using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallFall : MonoBehaviour
{
    public PhysicsMaterial2D ExMaterial;
    public GameObject LastBall;

    private GameObject Excellent;
    private bool G2 = false, G1 = false, Good = false, ex1 = false, ex2 = false, excellent = false;
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
        if(DontIceCream && collision.name == "G1")
        {
            G1 = true;
        }

        if (DontIceCream && collision.name == "G2")
        {
            G2 = true;
        }

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
            Debug.Log("Ex");
            excellent = true;
        }


        if (DontIceCream && ex2 && ex1)
        {
            Debug.Log("Good");
            Good = true;
        }

    }

    private void Update()
    {
        if (excellent && DontIceCream)
        {
            rb.velocity = Vector2.zero;
            coll.sharedMaterial = ExMaterial;

            gameObject.AddComponent<FrictionJoint2D>();
            FrictionJoint2D frictionJoint = GetComponent<FrictionJoint2D>();
            frictionJoint.connectedBody = LastBall.GetComponent<Rigidbody2D>();
            frictionJoint.maxTorque = 10;
            frictionJoint.maxForce = 2;
            frictionJoint.enableCollision = true;

            Excellent.transform.position = gameObject.transform.position - new Vector3(0.0f, 0.0538f, 0.0f);

            DontIceCream = false;
        }
    }
}

