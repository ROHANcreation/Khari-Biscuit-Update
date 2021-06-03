using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sc : MonoBehaviour
{

    Text text;
    public static int coinAmount;
    // Start is called before the first frame update
    public void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    public void Update()
    {
        text.text = coinAmount.ToString();
    }
}
