using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 20f;
    
    public Rigidbody2D bulletRb;
    public GameObject bullet;
    public GameObject drumstick;
    

    void Start()
    {
        bulletRb.velocity = transform.up * bulletSpeed;
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Quaternion drumstickRotation = Quaternion.Euler(1, 1, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, drumstickRotation, Time.deltaTime * 5f);
            Instantiate(drumstick, transform.position, transform.rotation);
            Destroy(collision.gameObject);
            Destroy(bullet);

        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(bullet);
        }
    }

}
