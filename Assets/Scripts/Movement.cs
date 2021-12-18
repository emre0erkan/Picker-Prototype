using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    private bool isMoving;
    Rigidbody rb = new Rigidbody();

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = 10;
        isMoving = true;
    }

    void FixedUpdate()
    {
        if (isMoving == true)
        {
            transform.position += transform.forward * Time.fixedDeltaTime * speed;
        }
        else if (isMoving == false)
        {
            speed = 0;
            //StartCoroutine(WaitForPool());
        }
        if (transform.position.y > 0.2f)
        {
            transform.position = new Vector3(transform.position.x, 0.2f, transform.position.z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Stop"))
        {                                          
            speed = 0;
        }
    }

    //IEnumerator WaitForPool()
    //{
    //    if (isMoving == false)
    //    {
    //        yield return new WaitForSeconds(4);
    //    }
    //}
}
