using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    public Rigidbody2D rocket;

    Vector2 movement;

    public float speed = 20f;
    float horizontalMove = 0f;
    float verticalMove = 0f;    
    public Animator animator;

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
       transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2f, 2f),
           Mathf.Clamp(transform.position.y, -4f, 4f), transform.position.z);

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

}