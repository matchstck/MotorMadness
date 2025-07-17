using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door13 : MonoBehaviour
{
    [SerializeField] public Animator myAnimationcontroller;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationcontroller.SetBool("door13.1", true);
        }
    }
}
