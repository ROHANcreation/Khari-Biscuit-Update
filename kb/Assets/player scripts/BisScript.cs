using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BisScript : MonoBehaviour
{
    private const int V = 0;
    public float Speed = 5f;
    private bool facingRight;
    public float jerk;
    private Rigidbody2D rb;
    private Animator anim;
    public bool moveInput = true;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        facingRight = true;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
            anim.SetBool("Runing Bis", true);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
            anim.SetBool("Runing Bis", true);

        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * Speed * Time.deltaTime);
            anim.SetBool("Jumping Bis", true);

        }
        else
        {
            anim.SetBool("Runing Bis", false);
            anim.SetBool("Jumping Bis", false);
        }
        

    }

    private void NewMethod()
    {
        anim.SetBool("Ideal Bis", false);
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");

        Flip(horizontal);
    }



    private void Flip(float horizontal)
    {
        if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale;
            theScale.x *= -1;

            transform.localScale = theScale;
        }
    }

    public void Jump()
    {
        rb.velocity = (Vector3.up * jerk);
    }

}
