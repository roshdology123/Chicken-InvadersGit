using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Bullet : MonoBehaviour
{
    public float eggSpeed = 5f;
    public Rigidbody2D rb;
    public GameObject bullet;
    public GameObject explosion;
    public GameObject rocket;
  //  int count = 0;


    public Animator animator;

    void Start()
    {
        rb.velocity = - transform.up * eggSpeed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject clone = (GameObject)Instantiate(explosion, transform.position, transform.rotation);
            Destroy(collision.gameObject);
            Destroy(clone, 1.5f);
            asteroid_0.count+=1;
            if (asteroid_0.count< 3)
            {
                Invoke("showRocket", 1.7f);       
            }
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            animator.SetFloat("speed", Mathf.Abs(0));
            rb.velocity = Vector3.zero;
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
    void showRocket()
    {
        Instantiate(rocket);
    }

}
