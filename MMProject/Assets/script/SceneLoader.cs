using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int level;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //level = whatlevel;
            //SceneManager.GetSceneByName(whatlevel);
            SceneManager.LoadScene(level);
        }
    }
}
