using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenu;

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    void Resume()
    {
        pauseMenu.SetActive(false);
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenu.SetActive(true);
        GameIsPaused = true;
    }
}
