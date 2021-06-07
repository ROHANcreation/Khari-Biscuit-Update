using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push : MonoBehaviour
{
    public float UF;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
           // transform.Translate(Vector3.up * UF * Time.deltaTime);
             rb.velocity = Vector2.up * UF;
        }
    }

}
