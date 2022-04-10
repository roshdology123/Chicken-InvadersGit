using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bondaries : MonoBehaviour
{
    void Start()
    {
        Count.counter = Count.getnumberofchickens();
        Count.bosscount = Count.endboss();

    }
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7.23f, 7.16f),
                   Mathf.Clamp(transform.position.y, -8.66f, 6.82f), transform.position.z);
        if (Count.counter == 0 && Count.bosscount == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        Debug.Log(Count.bosscount);
    }
}
