using UnityEngine;
using UnityEngine.UI;

public class RocketMovement : MonoBehaviour
{
    public Rigidbody2D rocket;

    Vector2 movement;

    public float speed = 20f;
    float horizontalMove = 0f;
    float verticalMove = 0f;    
    public Animator animator;
    public Text scoretext;

    void Start()
    {
        scoretext.text = "Score: " + Score.totalscore;
    }
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        
    }
    void FixedUpdate()
    {
        rocket.MovePosition(rocket.position + speed * Time.fixedDeltaTime * movement);
        horizontalMove = Input.GetAxis("Horizontal") * speed;
        verticalMove = Input.GetAxis("Vertical") * speed;

        if(horizontalMove != 0f)
        {
            animator.SetFloat("speed", Mathf.Abs(horizontalMove));
        }
        else
        {
            animator.SetFloat("speed", Mathf.Abs(verticalMove));
        }
        


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "drumstick")
        {
            Score.totalscore += 1;
            scoretext.text = "Score: " + Score.totalscore;

        }
    }

}