using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    private Rigidbody2D rb;

    public Vector3 respawnpoint;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
  

   void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "fd")
        {
            transform.position = respawnpoint;
        }

        if (other.gameObject.tag == "sp")
        {
            respawnpoint = other.transform.position;
        }


    }
}
