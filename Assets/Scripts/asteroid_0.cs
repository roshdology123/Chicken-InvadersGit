using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class asteroid_0 : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed;
    public float asteroidRate=-17f;
    public GameObject explosion;
    public static int count = 0;
   public GameObject rocket;
    public GameObject bullet;
    public Rigidbody2D rb;
    public Transform Rocket;
   void Start()
    {
        speed=Random.Range(5f,12f);
    }

    // Update is called once per frame
    void Update()
    {
      transform.Translate(Vector2.down*Time.deltaTime*speed);  
      if (transform.position.y<asteroidRate){
         newAsteroid(); 
      }  
    }
    void newAsteroid(){
        float randomNumber=Random.Range(-15f,15f);
        Vector2 newPosition=new Vector2(randomNumber,7);
        transform.position=newPosition;
        speed=Random.Range(10f,15f);
    }
    void OnTriggerEnter2D(Collider2D other){  
        if(other.gameObject.CompareTag("Player")){
            GameObject clone =(GameObject)Instantiate(explosion,transform.position,transform.rotation);       
            Destroy(clone,1.5f);
            FindObjectOfType<AudioManager>().Play("RocketExp");
            count +=1;
            if(count<3){
                  other.gameObject.transform.position = new Vector3(-13.69f, -6.63f, 0f);
            }else if(other.gameObject.CompareTag("bullet")){
                Destroy(bullet);      
            }
            else if (count ==3)
            {
                SceneManager.LoadScene("LoseMenu");
                asteroid_0.count = 0;
                Score.totalscore = 0;
                Shooting.fireRate = 0.8f;
            }
        }
        if (other.gameObject.CompareTag("Finish") || other.gameObject.CompareTag("Player"))
        {
            newAsteroid();
        }
    }
}
