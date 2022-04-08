using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bondaries : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7.23f, 7.16f),
                   Mathf.Clamp(transform.position.y, -8.66f, 6.82f), transform.position.z);
    }
}
