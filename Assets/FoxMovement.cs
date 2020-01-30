using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxMovement : MonoBehaviour
{
    //Global Variables.

    Animator theAnimator;
    bool idle;

    // Start is called before the first frame update
    void Start()
    {
        theAnimator = GetComponent<Animator>();
        InvokeRepeating("EarFlick", 5.0f, 9.0f);
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    void FixedUpdate()
    {
        theAnimator.SetBool("isWalking", false);
        theAnimator.SetBool("isRunning", false);
        theAnimator.SetBool("isSleeping", false);
        idle = true;

        if (Input.GetKey("right"))
            {
                //Stub. Move fox right.
            theAnimator.SetBool("isWalking", true);
            transform.rotation = Quaternion.Euler(0, 90, 0);
            transform.position += new Vector3(.1f, 0, 0);
            idle = false;
            }
        else if(Input.GetKey("left"))
            {
                //Stub. Move fox left.
            theAnimator.SetBool("isWalking", true);
		    transform.rotation = Quaternion.Euler(0, -90, 0);
            transform.position += new Vector3(-.1f, 0, 0);
            idle = false;

        }
        if (Input.GetKey("up"))
            {
            //Stub. Make the fox Jump.
            transform.position += new Vector3(0, .1f, 0);
            idle = false;

        }
        if (Input.GetKey("down"))
            {
            //Stub. Make the fox crouch. (Right now just moves down.)
            transform.position += new Vector3(0, -.1f, 0);
            idle = false;

        }

        if(idle)//Puts Fox to Sleep if User is away from keyboard after 15 seconds.
        {
            Invoke("Sleep", 15f);
        }
        else
        {
            CancelInvoke("Sleep");
        }

    }

    void EarFlick()
    {
        theAnimator.SetTrigger("earFlick");
    }

    void Sleep()
    {
        theAnimator.SetBool("isSleeping", true);
    }

}
