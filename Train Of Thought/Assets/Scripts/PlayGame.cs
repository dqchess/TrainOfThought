﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    public LevelFade LevelFade;
    public bool GameStart = false;

    public void StartGame()
    {
        GameStart = true;
        LevelFade.ButtonPressed = true;
    }

    public void QuitGame()
    {
        Debug.Log("Quitting Game");
    }

    public void OpenCredits()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
	    