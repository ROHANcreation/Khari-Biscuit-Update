using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using TMPro;
public class Movement : MonoBehaviour
{
    private int currentSceneIndex;
    private int sceneToContinue;
    public float x, y, z;


    public void Playbutton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Deletdata();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Deletdata();

    }

    public void continuebutton()
    {
        sceneToContinue = PlayerPrefs.GetInt("SavedScene");
        load();
        if (sceneToContinue != 0)
        {
            
            SceneManager.LoadScene(sceneToContinue);
            
        }
    }

    public void Deletdata()
    {
        PlayerPrefs.DeleteAll();
    }


    public void save()
    {
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;

        PlayerPrefs.SetFloat("x", x);
        PlayerPrefs.SetFloat("y", y);
        PlayerPrefs.SetFloat("z", z);
    }
    public void load()
    {
        x = PlayerPrefs.GetFloat("x");
        y = PlayerPrefs.GetFloat("y");
        z = PlayerPrefs.GetFloat("z");

        Vector3 LoadPosition = new Vector3(x, y, z);
        transform.position = LoadPosition;
    }
    public void exit()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedScene", currentSceneIndex);
        SceneManager.LoadScene("Main Manu");
        save();
    }
   

        
}
