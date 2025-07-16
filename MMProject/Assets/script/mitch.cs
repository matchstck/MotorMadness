using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.SceneManagement;

public class PauseMenu1 : MonoBehaviour
{
    public GameObject pauseMenuUI;

    [SerializeField] GameObject pauseMenu;

    public void Pause()

    {

        //pauseMenu.SetActive(true);
        Time.timeScale = 0f; 

    }

    public void Home()

    {

        SceneManager.LoadScene(0);

    }

    public void Resume()

    {

        //pauseMenu?.SetActive(false);
        Time.timeScale = 1f; 
        pauseMenuUI.SetActive(false);


    }

    public void Quit()

    {

        Application.Quit();

    }

}

