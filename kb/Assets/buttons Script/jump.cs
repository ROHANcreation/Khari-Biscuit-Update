using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    bool onTop;
    GameObject bouncer;
    Animator anim;
    public Vector2 velocity;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay2D(Collision2D other)
    {
        if (onTop)
        {
            anim.SetBool("Player", true);
            bouncer = other.gameObject;
        }
    }
    private void OnTriggerEnter2D()
    {
        onTop = true;

    }
    private void OnTriggerExit2D()
    {
        onTop = false;   
    }
   
}
