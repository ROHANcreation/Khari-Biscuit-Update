using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BScript : MonoBehaviour
{
    private const int V = 0;
    private const int V1 = 0;
    public float Speed = 5f;
    public float Speed2 = 5f;
    private bool facingRight;
    private SpriteRenderer spriterendererCheck;
    private Animator anim;
    public bool moveInput = true;
    public bool isRightpressed = false;
    public bool isLeftpressed = false;
    public bool isUppressed = false;


    // Start is called before the first frame update
    void Start()
    {
        facingRight = true;
        anim = GetComponent<Animator>();
        spriterendererCheck = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
     void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || isLeftpressed)
        {
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
            anim.SetBool("Bis Runing", true);
            spriterendererCheck.flipX = true;

        }

        else if (Input.GetKey(KeyCode.RightArrow) || isRightpressed)
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
            anim.SetBool("Bis Runing", true);
            spriterendererCheck.flipX = false;


        }
        else if (Input.GetKey(KeyCode.UpArrow) || isUppressed)
        {
            transform.Translate(Vector3.up * Speed2 * Time.deltaTime);
            anim.SetBool("Bis Jumping", true);
            
        }
        else
        {
            anim.SetBool("Bis Jumping", false);
            anim.SetBool("Bis Runing", false);
        }


    }

    private void NewMethod()
    {
        anim.SetBool("bis Ideal", false);
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
    public void rightpressed()
    {
        isRightpressed = true;
        Debug.Log("");
    }
    public void rightreleased()
    {
        isRightpressed = false;
        Debug.Log("");

    }

    public void leftpressed()
    {
        isLeftpressed = true;
        Debug.Log("");
        

    }
    public void leftreleased()
    {
        isLeftpressed = false;
        Debug.Log("");

    }

    public void uppressed()
    {
        isUppressed = true;
        Debug.Log("buttonPressed");

    }
    public void upreleased()
    {
        isUppressed = false;
        Debug.Log("buttonReleased");
    }


}
