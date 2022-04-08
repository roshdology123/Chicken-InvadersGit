using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
    float timer = 0f;
    readonly float timeToMove = 0.5f;
    int numOfMovements = 0;
    float speed = 0.25f;
    
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > timeToMove)
        {
            transform.Translate(new Vector3(speed, 0, 0));
            timer = 0;
            numOfMovements += 1;
        }
        if(numOfMovements == 18)
        {
            speed = -speed;
            numOfMovements = 0;
        }


    }
}
