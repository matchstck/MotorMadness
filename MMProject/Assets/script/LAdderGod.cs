using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LAdderGod : MonoBehaviour
{
    
    public Transform chController;
    bool inside = false;
    public float speedUpDown = 3.2f;
    public FPSMovement FPSInput;
    // Start is called before the first frame update
    
        void Start()
    {
        FPSInput = GetComponent<FPSMovement>();
        inside = false;
    }
    
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "ladde r")
        {
            FPSInput.enabled = true;
            inside = !inside;

        }
    }
    // Update is called once per frame
    
    void Update()
    {
        if(inside == true)
        {
            FPSInput.m_gravity = 0;
        }
        else
        {
           FPSInput.m_gravity = -9.8f;
        }
        if(inside == true && Input.GetKey("w"))
        {
            chController.transform.position += Vector3.up /
                speedUpDown;
        }

        if (inside == true && Input.GetKey("s"))
        {
            chController.transform.position += Vector3.down /
                speedUpDown;
        }

    }
}
