using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {

    public float movementSpeed = 2f;
    private int direction = 1;
    private Vector2 startpos;
    private int maxOffset = 4;
    public float attackTimer = 0;
    public bool facingRight;
    public Rigidbody2D rigid;

    // Use this for initialization
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        startpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        ChangeDirAfterTime();

    }

    void Movement()
    {
        rigid.velocity = Vector2.right  * movementSpeed * direction;
    }

    void ChangeDirAfterTime()
    {

        if (transform.position.x > startpos.x + maxOffset)
        {
            direction = -1;
            //print(direction);
            if (!facingRight)
            {
                Flip();
            }

        }
        else if (transform.position.x < startpos.x - maxOffset)
        {
            direction = 1;
            //print(direction);
            if (facingRight)
            {
                Flip();
            }
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}