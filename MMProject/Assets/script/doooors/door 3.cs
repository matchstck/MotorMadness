using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door3 : MonoBehaviour
{
    [SerializeField] private Animator myAnimationcontroller;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationcontroller.SetBool("door3.3", true);
        }
    }
}