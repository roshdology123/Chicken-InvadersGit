using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gift : MonoBehaviour
{
    private float speed;
    public float giftRate=-50f;
     public GameObject bullet;
     public GameObject Gift;
    // Start is called before the first frame update
    void Start()
    {
        speed=Random.Range(8f,10f);
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
        float randomNumber=Random.Range(-11f,11f);
        Vector2 newPosition=new Vector2(randomNumber,7);
        transform.position=newPosition;
        speed=Random.Range(8f,10f);
         if(Random.Range(0f,2000f) < 1)
            {
            Instantiate(Gift,transform.position,transform.rotation);
            }
        }
     void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
          if (asteroid_0.count<3){
             Shooting.fireRate*=0.75f;
             Destroy(gameObject);
             }
            // else if(other.gameObject.CompareTag("bullet")){
            //      Destroy(bullet);
            //  }
            else{
                Shooting.fireRate= 0.8f;
            }
        }
            }
 }