using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public float Health;
    public Slider Phealth;
    public GameObject retry;
    // Start is called before the first frame update
    void Start()
    {
        Health = PlayerPrefs.GetFloat("health");
    }

    // Update is called once per frame
    void Update()
    {
        Phealth.value = Health;

        if (Health <=0)
        {
            Health = 0;
            retry.SetActive(true);
        }

        if (Health > 100)
        {
            Health = 100;
        }

        PlayerPrefs.SetFloat("health", Health);
    }

  
        
    
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "dam1")
        {
            Health = Health -5f;
        }

        if (other.gameObject.tag == "dam2")
        {
            Health = Health - 10f;
        }

        if (other.gameObject.tag == "dam3")
        {
            Health = Health - 20f;
        }

        if (other.gameObject.tag == "health")
        {
            Health = Health +10f;
        }
    }

    public void restrt()
    {
        Health = 40;
    }
}
