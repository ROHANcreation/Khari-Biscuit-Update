using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ccoll: MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        sc.coinAmount += 1;
        Destroy(gameObject);
    }
}
