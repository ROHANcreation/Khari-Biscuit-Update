using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class pause : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject PausemaunUI;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }

        }
    }

    void Resume ()
    {
        PausemaunUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause ()
    {
        PausemaunUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = (true);
    }
}
