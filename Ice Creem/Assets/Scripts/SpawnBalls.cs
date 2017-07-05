using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalls : MonoBehaviour {

    public List<GameObject> Balls;
    public Transform SpawnPos;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            int RandomValue;
            RandomValue = Random.Range(0, 10);
            Instantiate(Balls[RandomValue], SpawnPos.position, Quaternion.identity);
        }
    }
}
