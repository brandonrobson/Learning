using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(currentSceneIndex < 3)
        {
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
