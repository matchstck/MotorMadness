using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door9 : MonoBehaviour
{
    [SerializeField] public Animator myAnimationcontroller;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationcontroller.SetBool("door9.9", true);
        }
    }
}
