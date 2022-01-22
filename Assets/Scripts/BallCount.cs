using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class BallCount : MonoBehaviour
{
    public static int ballCount;
    public Text ballCountText;
    private float poolSpeed = 1;
    public static int goal = 3;

    private void Start()
    {
        DOTween.Init();
        ballCountText.text = ballCount.ToString() + "/" + goal.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Ball"))
        {
            ballCount++;
            ballCountText.text = ballCount.ToString() + "/" + goal.ToString();
            StartCoroutine(WaitForPool());
            Destroy(other.gameObject);
        }
    }

    private void FixedUpdate()
    {
        PoolUp();
        KeepGoing();
    }

    private void PoolUp()
    {
        if (ballCount >= goal)
        {
            if (transform.position.y < -0.019998)
            {
                StartCoroutine(WaitForPool());
                transform.DOMoveY(0, 1);

            }
            else poolSpeed = 0;
        }
    }

    private void KeepGoing()
    {
        if (transform.position.y > -0.019990)
        {
            Movement.speed = 750;
        }
    }

    //IEnumerator DestroyBall()
    //{
    //    yield return new WaitForSecondsRealtime(4f);
    //}

    IEnumerator WaitForPool()
    {
        yield return new WaitForSecondsRealtime(3f);
    }

}
