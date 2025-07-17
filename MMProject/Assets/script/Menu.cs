using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnPlayButton()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.None;

    }
    public void OnQuitButton()
    {
        Application.Quit();
    }
}

