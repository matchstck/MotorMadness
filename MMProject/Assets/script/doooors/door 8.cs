using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door8 : MonoBehaviour
{
    [SerializeField] private Animator myAnimationcontroller;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationcontroller.SetBool("door8.8", true);
        }
    }
}
