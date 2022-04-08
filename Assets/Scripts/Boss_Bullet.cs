using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float eggSpeed = 5f;
    public Rigidbody2D rb;
    public GameObject bullet;
    public GameObject explosion;
    public GameObject rocket;
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
            
            Destroy(clone, 1.5f);
            rocket.SetActive(false);
            asteroid_0.count+=1;
            if (asteroid_0.count< 3)
            {
                Invoke("showRocket", 1.7f);       
            }
            Debug.Log("Executed");
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            animator.SetFloat("speed", Mathf.Abs(0));
            rb.velocity = Vector3.zero;
            StartCoroutine(WaitThenDie());
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
