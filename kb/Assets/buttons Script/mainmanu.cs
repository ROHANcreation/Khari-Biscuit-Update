using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmanu : MonoBehaviour
{
    private int currentSceneIndex;
    private int sceneToContinue;
    public void Playbutton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void continuebutton()
    {
        sceneToContinue = PlayerPrefs.GetInt("SavedScene");

        if (sceneToContinue != 0)
        {
            SceneManager.LoadScene(sceneToContinue);
        }

        else
        {
            return;
        }
            
    }

    public void Quitbutton()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void exit()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedScene", currentSceneIndex);
        SceneManager.LoadScene("Main Manu");
    }

}
