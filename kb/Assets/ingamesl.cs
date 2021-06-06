using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ingamesl : MonoBehaviour
{
    public Slider ingame;
    // Start is called before the first frame update
    void Start()
    {
        ingame.value = PlayerPrefs.GetFloat("IGV");
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.GetFloat("IGV", ingame.value);
    }
}
