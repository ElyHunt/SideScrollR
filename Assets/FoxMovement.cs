using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if(Input.GetKey("right"))
            {
                //Stub. Move fox right.
                transform.position += new Vector3(.1f, 0, 0);
            }
        if(Input.GetKey("left"))
            {
                //Stub. Move fox left.
                transform.position += new Vector3(-.1f, 0, 0);
            }
        if(Input.GetKey("up"))
            {
                //Stub. Make the fox Jump.
                transform.position += new Vector3(0, .1f, 0);
            }
        if(Input.GetKey("down"))
            {
                //Stub. Make the fox crouch. (Right now just moves down.)
                transform.position += new Vector3(0, -.1f, 0);
            }
    }

}
