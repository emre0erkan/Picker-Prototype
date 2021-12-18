using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallCount : MonoBehaviour
{
    public int ballCount;
    public Text ballCountText;
    private float speed = 1;
    private bool canContinue;
    public int goal = 3;


    private void Start()
    {
        ballCountText.text = ballCount.ToString() + "/" + goal.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Ball"))
        {
            ballCount++;
            ballCountText.text = ballCount.ToString() + "/" + goal.ToString();
        }
    }

    private void Update()
    {
        PoolUp();
    }

    private void PoolUp()
    {
        if (ballCount >= goal)
        {
            if (transform.position.y < 0)
                transform.position += transform.up * Time.deltaTime * speed;
            else speed = 0;
        }
    }

}
