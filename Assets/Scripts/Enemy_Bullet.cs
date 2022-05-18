using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Enemy_Bullet : MonoBehaviour
{
    public float eggSpeed = 5f;
    public Rigidbody2D rb;
    public GameObject bullet;
    public GameObject explosion;
    public GameObject rocket;
 


    public Animator animator;

    void Start()
    {
        rb.velocity = - transform.up * eggSpeed;
        FindObjectOfType<AudioManager>().Play("Egg");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            GameObject clone = (GameObject)Instantiate(explosion, transform.position, transform.rotation);
            Destroy(clone, 1.5f);
            FindObjectOfType<AudioManager>().Play("RocketExp");
            asteroid_0.count+=1;
            if (asteroid_0.count< 3)
            {
                collision.gameObject.transform.position = new Vector3(-13.69f, -6.63f, 0f);
            }
            else if(asteroid_0.count == 3)
            {
                SceneManager.LoadScene("LoseMenu");
                asteroid_0.count = 0;
                Score.totalscore = 0;
                Shooting.fireRate = 0.8f;
            }
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


}
