using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class restart : MonoBehaviour
{
  public void RestartGame()

    {
        SceneManager.LoadScene("Level 01");
    }

    public void RestartGame2()
    {
        SceneManager.LoadScene("Level 02");
    }
    public void RestartGame3()
    {
        SceneManager.LoadScene("Level 03");
    }
}
