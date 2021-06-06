using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmanu : MonoBehaviour
{
   
    public void Playbutton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //if (File.Exists(Application.persistentDataPath + "")) ;
    }

   
            
    

    public void Quitbutton()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

   

}
