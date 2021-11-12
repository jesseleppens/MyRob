using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void NextScene()
    {   
        //switches to the next scene and if it is the last scene it changes to the first scene
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
        //switches to the previous scene. if it is the first scene then switches to the last scene
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
