﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Buttons : MonoBehaviour
{
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    
}

