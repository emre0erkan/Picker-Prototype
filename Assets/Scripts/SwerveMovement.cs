using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveMovement : MonoBehaviour
{
    //Rigidbody rb;

    //private float lastFrameFingerPositionX;
    //private float moveFactorX;
    //public float swerveAmount;
    //private float speed = 1;
    //public float MoveFactorX => moveFactorX;

    //[SerializeField] private float swerveSpeed = 0.5f;
    //[SerializeField] private float maxSwerveAmount = 2f;

    //private void Start()
    //{
    //    rb = GetComponent<Rigidbody>();
    //}

    //void FixedUpdate()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        lastFrameFingerPositionX = Input.mousePosition.x;
    //    }
    //    else if (Input.GetMouseButton(0))
    //    {
    //        moveFactorX = Input.mousePosition.x - lastFrameFingerPositionX;
    //        lastFrameFingerPositionX = Input.mousePosition.x;
    //    }
    //    else if (Input.GetMouseButtonUp(0))
    //    {
    //        moveFactorX = 0f;
    //    }

    //    float swerveAmount = MoveFactorX * swerveSpeed * Time.deltaTime;
    //    swerveAmount = Mathf.Clamp(swerveAmount, -maxSwerveAmount, maxSwerveAmount);

        //transform.Translate(swerveAmount, 0, 0);       //rigidbody ekle
        //Vector3 swerve = new Vector3(swerveAmount, 0, 0);
        //rb.MovePosition(rb.position + swerve* Time.deltaTime);
        //Vector3 swerveAmount2 = transform.right * swerveAmount* Time.fixedDeltaTime * speed;
        //rb.MovePosition(rb.position + swerveAmount2);
        //rb.AddForce(swerve);
        //rb.velocity = new Vector3(swerveAmount, rb.velocity.y, rb.velocity.z);
        //rb.transform.position += new Vector3(swerveAmount, 0, 0);

        //Vector3 tempVect = new Vector3(swerveAmount, 0, 0);
        //tempVect = tempVect.normalized * Time.deltaTime;
        //rb.MovePosition(newPos);

    //}
}
