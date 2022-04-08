using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject eggPrefab;
    public Transform firePoint;
    void Update()
    {
        FireBossEgg();
    }
    void FireBossEgg()
    {
        if(Random.Range(0f,20f) < 1)
        {
            Instantiate(eggPrefab, firePoint.position, firePoint.rotation);

        }
    }
}
