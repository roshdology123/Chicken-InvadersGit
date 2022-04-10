using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gift : MonoBehaviour
{
    private float speed;
    public float giftRate=-17f;
    // Start is called before the first frame update
    void Start()
    {
        speed=Random.Range(1f,5f);
    }

    // Update is called once per frame
    void Update()
    {
    transform.Translate(Vector2.down*Time.deltaTime*speed);  
      if (transform.position.y<giftRate){
         newGift(); 
      }  
    }
    void newGift(){
        float randomNumber=Random.Range(-7.8f,7.8f);
        Vector2 newPosition=new Vector2(randomNumber,7);
        transform.position=newPosition;
        speed=Random.Range(1f,5f);
        }
     void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
          if (asteroid_0.count<3){
             Shooting.fireRate*=0.75f;
             }
            }else if(asteroid_0.count == 3){
                Shooting.fireRate= 0.8f;
            }
        if (other.gameObject.CompareTag("Finish") || other.gameObject.CompareTag("Player"))
        {
            newGift();
         }
     }
    }
     
