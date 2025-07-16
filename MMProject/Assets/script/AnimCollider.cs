using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimCollider : MonoBehaviour
{
    private Animator animator;

    public AnimationClip clip;

    private Animation animationComponent;

    void Start()

    {

        animator = GetComponent<Animator>();

    }

    void Update()

    {

    }

    private void OnCollisionEnter(Collision other)

    {

        if (other.gameObject.CompareTag("Player"))

        {

            animationComponent.Play(clip.name);

        }

    }



}
