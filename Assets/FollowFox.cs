using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowFox : MonoBehaviour
{
    GameObject fox;
    // Start is called before the first frame update
    void Start()
    {
        fox = GameObject.Find("Fox");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        //transform.LookAt((GameObject.Find("Fox")).transform);
        transform.position = new Vector3(fox.transform.position.x, fox.transform.position.y+3f, transform.position.z);
        

    }

}
