using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RotateBarrier : MonoBehaviour
{
    BallCount balls;
    public GameObject leftBarrier;
    public GameObject rightBarrier;

    private bool opening = true;
    private float turnspeed = 100;

    void Start()
    {
        leftBarrier = GetComponent<GameObject>();
        rightBarrier = GetComponent<GameObject>();

        DOTween.Init();
        balls = GetComponent<BallCount>();
    }

    void FixedUpdate()
    {
        if (BallCount.ballCount >= BallCount.goal && opening)
        {
            leftBarrier.transform.DORotate(new Vector3(0, 0, 90), 2f, RotateMode.Fast);
            rightBarrier.transform.DORotate(new Vector3(0, 0, -90), 2f, RotateMode.Fast);
        }
    }
}
