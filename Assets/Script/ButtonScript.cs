using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void FinishGameExit()
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void Credits()
    {
        SceneManager.LoadSceneAsync(3);
    }
}
