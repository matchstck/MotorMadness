using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door18 : MonoBehaviour
{
    [SerializeField] public Animator myAnimationcontroller;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationcontroller.SetBool("door18.1", true);
        }
    }
}
