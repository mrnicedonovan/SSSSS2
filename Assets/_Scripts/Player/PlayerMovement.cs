using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    Animator animator;
    public float speed;
    public float jumpSpeed;
    public bool facingRight;
    private bool isJumping;
    private Rigidbody2D _Body;
 

    void Start()
    {
        animator = GetComponent<Animator>();
        _Body = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("trans1", true);
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            if (facingRight)
            {
                Flippie();
            }
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(Vector2.right * speed * 2 * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.right * -speed * Time.deltaTime);
            animator.SetBool("trans1", true);
            if (!facingRight)
            {
                Flippie();
            }
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(Vector2.right * -speed * 2 * Time.deltaTime);
            }
        }
        

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (isJumping == true)
            {
                //animator.SetTrigger("jump?");
                _Body.velocity = Vector2.up * jumpSpeed;
                
                isJumping = false;
            }


        }



    }


    void OnCollisionEnter2D(Collision2D Collider2D)
    {
        if (Collider2D.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
            //animator.SetTrigger("Idle");
        }
    }

    void Flippie()
    {
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}