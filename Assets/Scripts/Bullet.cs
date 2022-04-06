using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 20f;
    public Rigidbody2D rb;
    public GameObject bullet;

    void Start()
    {
        rb.velocity = transform.up * bulletSpeed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(bullet);

        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(bullet);
        }
    }

}
