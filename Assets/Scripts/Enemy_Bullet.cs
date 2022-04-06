using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Bullet : MonoBehaviour
{
    public float eggSpeed = 5f;
    public Rigidbody2D rb;
    public GameObject bullet;



    public Animator animator;

    void Start()
    {
        rb.velocity = - transform.up * eggSpeed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            
            Destroy(bullet);

        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            animator.SetFloat("speed", Mathf.Abs(0));
            StartCoroutine(WaitThenDie());

            
        }
        if (collision.gameObject.CompareTag("Egg"))
        {
            Destroy(bullet);
        }
    }
    IEnumerator WaitThenDie()
    {
        yield return new WaitForSeconds(3);
        Destroy(bullet);
    }

}
