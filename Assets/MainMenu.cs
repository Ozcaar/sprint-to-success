using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // Load the next scene in the build index
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(1);
    }

    public void QuitGame()
    {
        // Quit the game
        Application.Quit();
    }

    public void ReturnToMainMenu()
    {
        // Load the main menu scene
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(0);
    }
}