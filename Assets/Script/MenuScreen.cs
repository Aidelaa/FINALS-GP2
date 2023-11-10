using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UIElements;

public class ButtonAnimations : MonoBehaviour
{
    public GameObject startButton, optionsButton, creditsButton, quitGameButton;

    void Start()
    {
        startGame();
        options();
        credits();
        quitGame();
    }

    private void startGame()
    {

    }

    private void options()
    {

    }

    private void credits()
    {

    }

    private void quitGame()
    {
        Application.Quit();
    }
}