using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void NextScene()
    {      
        if (SceneManager.GetActiveScene().buildIndex + 1 == 5)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        } 
    }

    public void PreviousScene()
    {       
        if (SceneManager.GetActiveScene().buildIndex - 1 == -1)
        {
            SceneManager.LoadScene(4);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
