using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door20 : MonoBehaviour
{
    [SerializeField] public Animator myAnimationcontroller;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationcontroller.SetBool("door20.1", true);
        }
    }
}
