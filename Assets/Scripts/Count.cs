using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count : MonoBehaviour
{
    public static int counter = 0;
    public static int bosscount = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public static int getnumberofchickens()
    {
        return GameObject.FindGameObjectsWithTag("Enemy").Length;

    }
    public static int endboss()
    {
        return GameObject.FindGameObjectsWithTag("boss").Length;

    }
}
