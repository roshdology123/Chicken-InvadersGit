using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject eggPrefab;
    public Transform firePoint;
    public HealthBar healthBar;
    public GameObject bossExplosion;
 

    void Update()
    {
        FireBossEgg();
        if (Health.TotalHealth <= 0)
        {
            GameObject clone = (GameObject)Instantiate(bossExplosion, transform.position, transform.rotation);
            Destroy(clone, 1.5f);
            Destroy(gameObject);
            Count.bosscount--;
            asteroid_0.count = 0;
            Score.totalscore = 0;
            Shooting.fireRate = 0.8f;
        }
    }
    void FireBossEgg()
    {
        if(Random.Range(0f,400f) < 1)
        {
            Instantiate(eggPrefab, firePoint.position, firePoint.rotation);

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "bullet")
        {
            healthBar.Damage(0.009f);
        }
    }
}
