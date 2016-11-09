﻿using UnityEngine;
using System.Collections;

public class PauseMenuScript : MonoBehaviour
{

    public bool isPaused;
    public GameObject pauseMenu;
    public GameObject hud;

    void Update()
    {

        if (isPaused)
        {
            pauseMenu.SetActive(true);
            hud.SetActive(false);
            Time.timeScale = 0;
        }
        else
        {
            pauseMenu.SetActive(false);
            hud.SetActive(true);
            Time.timeScale = 1;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }
    }

    public void Resume()
    {
        isPaused = false;
        Time.timeScale = 1;
    }

    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void MainMenu()
    {
        Application.LoadLevel(0);
    }

    public void Quit()
    {
        Application.Quit();
    }
}