using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class volume : MonoBehaviour
{
    public AudioMixer AM;
    public Slider volslider;
    // Start is called before the first frame update
    void Start()
    {
        volslider.value = PlayerPrefs.GetFloat("volum");
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("volum", volslider.value);
    }
   

    public void SetVolume(float vol)
    {
        AM.SetFloat("audio", vol);
       
    }

}
