using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowFox : MonoBehaviour
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
        transform.LookAt((GameObject.Find("Fox")).transform);
    }

}
