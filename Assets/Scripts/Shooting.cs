using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public Rigidbody2D rb;

    public static float fireRate = 0.8f;
    public float nextFire = 0f;
       

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Shoot();
        }

    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position , firePoint.rotation);
    }
}
