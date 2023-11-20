using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    public void startgame(string LivingRoom)
    {
        SceneManager.LoadScene(LivingRoom);
    }

    public void settingMenu(string OptionScene)
    {
        SceneManager.LoadScene(OptionScene);
    }

    public void credits(string CreditsScene)
    {
        SceneManager.LoadScene(CreditsScene);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
