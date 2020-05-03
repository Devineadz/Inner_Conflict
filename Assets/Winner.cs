using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winner : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject gameWonUI;

    void Update()
    {
        if (gameWonUI.activeSelf)
        {
            Time.timeScale = 0f;
        }
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void QuitGame()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }

    public void backToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void nextLevel()
    {
        gameWonUI.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level2");


    }
}
