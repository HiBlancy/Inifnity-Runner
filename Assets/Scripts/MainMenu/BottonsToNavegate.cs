using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BottonsToNavegate : MonoBehaviour
{
    public void StartButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void BackToMain()
    {
        SceneManager.LoadScene("MainMenu");
    }
}