using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D col)
    {
        score.coinAmount= 1;
        Destroy(gameObject);
    }
}
