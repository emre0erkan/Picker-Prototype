using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class BallCount : MonoBehaviour
{
    public GameObject subPool;
    public GameObject leftBarrier;
    public GameObject rightBarrier;

    public static int ballCount;
    public Text ballCountText;
    public static int goal = 3;

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
            Destroy(other.gameObject);
            if (ballCount >= goal)
            {
                PoolUp();
            }
        }
    }

    private void PoolUp()
    {

        subPool.transform.DOMoveY(0, 1);
        rightBarrier.transform.DORotate(new Vector3(0, 0, -90), 2f, RotateMode.Fast).OnComplete(() => { Movement.speed = 750; StartCoroutine(CanStop()); });
        leftBarrier.transform.DORotate(new Vector3(0, 0, 90), 2f, RotateMode.Fast);
    }

    IEnumerator CanStop()
    {
        yield return new WaitForSeconds(2f);
        Movement.canStop = true;
    }

}
