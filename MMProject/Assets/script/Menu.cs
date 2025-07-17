using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public GameObject pauseMenuUI;

    public void OnPlayButton()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.None;
        pauseMenuUI.SetActive(false);


    }
    public void OnQuitButton()
    {
        Application.Quit();
    }
}

