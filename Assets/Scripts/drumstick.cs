using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drumstick : MonoBehaviour
{
    public GameObject drumstickPrefab;
    public float drumstickSpeed = 10f;
    public float rotateSpeed = 10f;
    public Rigidbody2D drumstickRb;
    public Transform drumstickRotation;
    public float speed = 0f;

    void Start()
    {
        drumstickRb.velocity = transform.up * drumstickSpeed;
        transform.Rotate(rotateSpeed, rotateSpeed, rotateSpeed);
    }
    void FixedUpdate()
    {
        speed += 2;
        drumstickRotation.rotation = Quaternion.Euler(0, 0, speed);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            drumstickRb.velocity = Vector3.zero;
            drumstickRb.gravityScale = 0;
            drumstickRotation.rotation = Quaternion.Euler(0, 0, 0);
            speed = 0f;
            StartCoroutine(WaitThenDie());
            
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(drumstickPrefab);
            FindObjectOfType<AudioManager>().Play("Point");
        }
    }
    IEnumerator WaitThenDie()
    {
        yield return new WaitForSeconds((float)0.25);
        Destroy(drumstickPrefab);
    }
}
