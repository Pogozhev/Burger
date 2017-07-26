using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastballCheck : MonoBehaviour {

    public GameObject LastBall;

    private void Start()
    {
        LastBall = GameObject.Find("Start");
    }
}
