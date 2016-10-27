using UnityEngine;
using System.Collections;


/*
 * Author Name : Arun Bharath Krishnan
 * Last Modified Date : 26-0ct-2014
 * Last Modified by : Arun Bharath Krishnan
 * This Class is to define the game controller options and working functions.
 */

public class GameController : MonoBehaviour {

    public bool facingRight = true;
    public bool jump = true;

    public float moveForce = 365f;
    public float maxSpeed = 5f;
    public float jumpForce = 1000f;
    public Transform groundCheck;

    private bool grounded = false;
    private Animator animator;
    private Rigidbody2D rg2d;

	// Use this for initialization
	void Awake ()
    {
        animator = GetComponent<Animator>();
        rg2d = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));

        if(Input.GetButtonDown("Jump") && grounded)
        {
            jump = true;
        }
	}

    void flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");

        animator.SetFloat("Speed", Mathf.Abs(h));

        if (h * rg2d.velocity.x < maxSpeed)
            rg2d.AddForce(Vector2.right * h * moveForce);

        if (Mathf.Abs(rg2d.velocity.x) > maxSpeed)
            rg2d.velocity = new Vector2(Mathf.Sign(rg2d.velocity.x) * maxSpeed, rg2d.velocity.y);

        if (h > 0 && !facingRight)
            flip();
        else if (h < 0 && facingRight)
            flip();

        if (jump)
        {
            animator.SetTrigger("Jump");
            rg2d.AddForce(new Vector2(0f, jumpForce));
            jump = false;
        }
    }
}
