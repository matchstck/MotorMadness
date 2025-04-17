using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.SceneManagement;

public class PauseMenu1 : MonoBehaviour

{

    [SerializeField] GameObject pauseMenu;

    public void Pause()

    {

        pauseMenu.SetActive(true);

    }

    public void Home()

    {

        SceneManager.LoadScene(0);

    }

    public void Resume()

    {

        pauseMenu?.SetActive(false);

    }

    public void Quit()

    {

        Application.Quit();

    }

}

