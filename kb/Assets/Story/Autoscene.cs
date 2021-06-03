using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using DG.Tweening;
using UnityEngine.SceneManagement;

public class Automaticscenechangescript : MonoBehaviour
{
 
    void Start()
    {
       //DOVirtual.DelayedCall(53, GotoNextScene);
    }

  
    void GotoNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
