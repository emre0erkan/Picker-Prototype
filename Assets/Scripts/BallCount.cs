using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class BallCount : MonoBehaviour
{
    public GameObject subPool;
    public GameObject leftBarrier;
    public GameObject rightBarrier;

    public int _ballCount;
    public Text ballCountText;
    public int goal;
    public int _whichPool;


    
    private void Start()
    {
        goal = 3;
        _whichPool = 1;
        ballCountText.text = _ballCount.ToString() + "/" + goal.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Ball"))
        {
            this.tag = "Untagged";
            _ballCount++;
            ballCountText.text = _ballCount.ToString() + "/" + goal.ToString();
            if (_ballCount >= goal)
            {
                StartCoroutine(DestroyBalls(other.gameObject));
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

    IEnumerator DestroyBalls(GameObject other)
    {
        yield return new WaitForSeconds(1);
        Destroy(other.gameObject);
        PoolUp();
    }
}
