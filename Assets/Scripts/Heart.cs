using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    // Update is called once per frame
    void Update()
    {
         transform.Rotate(new Vector3(0f,100f,0f)*Time.deltaTime);
         hideLife();
    }
    void hideLife(){
        if (asteroid_0.count==1){
            Destroy(heart1);
        }else if (asteroid_0.count==2){
            Destroy(heart2);
            Destroy(heart1);
        }
    }
}
