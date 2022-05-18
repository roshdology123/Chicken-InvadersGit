using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject eggPrefab;
    public Transform firePoint;
    

    public Rigidbody2D rb;

    void Update()
    {
        FireEnemyEgg();
    }
    void FireEnemyEgg()
    {
        if(Random.Range(0f,5000f) < 1)
        {
            Instantiate(eggPrefab, firePoint.position, firePoint.rotation);

        }
    }
}
