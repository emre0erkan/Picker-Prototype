using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody ballRB = new Rigidbody();
    void Start()
    {
        ballRB = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        //if(transform.position.y > 0.65f)
        //{
        //    transform.position = new Vector3(transform.position.x, 0.65f, transform.position.z);
        //} else if(transform.position.y < 0.65f)
        //{
        //    transform.position = new Vector3(transform.position.x, 0.65f, transform.position.z);
        //}
    }
}
