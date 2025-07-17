using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door6 : MonoBehaviour
{
    [SerializeField] private Animator myAnimationcontroller;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationcontroller.SetBool("door6.6", true);
        }
    }
}
