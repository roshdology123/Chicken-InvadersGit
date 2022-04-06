using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bondaries : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -5f, 5f),
                   Mathf.Clamp(transform.position.y, -6f, 6f), transform.position.z);
    }
}
