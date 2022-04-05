using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    public Rigidbody2D rocket;

    Vector2 movement;

    public float speed = 20f;
    float horizontalMove = 0f;
    float verticalMove = 0f;    
    public Animator animator;

    private void Start()
    {
        Rigidbody2D rocket = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        
    }
    void FixedUpdate()
    {
        rocket.MovePosition(rocket.position + movement * speed * Time.fixedDeltaTime);
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

}