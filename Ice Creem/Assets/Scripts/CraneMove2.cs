using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraneMove2 : MonoBehaviour
{
    public Transform Point;
    public float DegPerSec;

    private float qwer = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.name == "LeftBound")
        {
            qwer = 1;
        }

        if (collision.name == "RightBound")
        {
            qwer = -1;
        }
    }

    private void Update()
    {
        transform.RotateAround(Point.position, new Vector3(0.0f, 0.0f, qwer), Time.deltaTime * DegPerSec);
    }
}
