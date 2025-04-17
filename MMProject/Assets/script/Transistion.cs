using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transistion : MonoBehaviour
{

    void Start()
    {
       
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            SceneManager.LoadScene(0);
            Cursor.visible = true;

            // Optionally, allow the cursor to move freely
            Cursor.lockState = CursorLockMode.None;
        }
    }

    
}