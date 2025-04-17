using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transistion1 : MonoBehaviour
{

    void Start()
    {
       
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            {

            SceneManager.LoadScene(1);
            Cursor.visible = true;

            // Optionally, allow the cursor to move freely
            Cursor.lockState = CursorLockMode.None;
        }
    }

    
}