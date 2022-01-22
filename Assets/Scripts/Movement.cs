using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public static float speed = 750;
    private bool isMoving;
    public static bool canStop = true;
    [SerializeField] private float lerpSpeed = 5;
    public float swerveAmount;

    SwerveInputSystem swerveInput;
    Rigidbody rb;

    [SerializeField] private float swerveSpeed;
    [SerializeField] private float maxSwerveAmount;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        swerveInput = GetComponent<SwerveInputSystem>();
        isMoving = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (canStop && other.gameObject.tag.Equals("Stop"))
        {
            speed = 0;
            canStop = false;
        }
    }
    void FixedUpdate()
    {
        if (isMoving == true)
        {
            Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;        //moving forward 
            Vector3 sideMove = transform.right * swerveSpeed * swerveInput.MoveFactorX * Time.fixedDeltaTime;
            rb.velocity = Vector3.Lerp(rb.velocity, sideMove + forwardMove, lerpSpeed * Time.fixedDeltaTime);
        }
        
        else if (isMoving == false)
        {
            speed = 0;
        }
    }
}
