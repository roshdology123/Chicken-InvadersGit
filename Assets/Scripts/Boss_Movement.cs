using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Movement : MonoBehaviour
{
    // Start is called before the first frame update
     float timer = 0f;
    readonly float timeToMove = 0.5f;
    int numOfMovements = 0;
    float speed = 0.9f;
    
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > timeToMove)
        {
            transform.Translate(new Vector3(speed, 0, 0));
            timer = 0;
            numOfMovements += 1;
        }
        if(numOfMovements == 13)
        {
            speed = -speed;
            numOfMovements = 0;
        }


    }
}
