using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;


public class LAdderGod : MonoBehaviour
{
    
    public Transform chController;
    bool inside = false;
    public float speedUpDown = 3.2f;
    public FPSMovement FPSInput;
    private float holder;
    // Start is called before the first frame update
    
        void Start()
    {
        FPSInput = GetComponent<FPSMovement>();
        inside = false;
        holder = FPSInput.m_gravity;
    }
    
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "ladde r")
        {

            FPSInput.enabled = true;
            inside = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "ladde r")
        {
            FPSInput.enabled = true;
            inside = false;

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
           FPSInput.m_gravity = holder;
        }
        if(inside == true && Input.GetKey("w"))
        {
             chController.transform.position += Vector3.up /
                speedUpDown;

            //FPSInput.m_isGrounded = false;
        }

        if (inside == true && Input.GetKey("s") )
        {
            
            chController.transform.position += Vector3.down /
                speedUpDown;
            

        }

    }
}
