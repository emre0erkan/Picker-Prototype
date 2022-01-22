using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoTweenController : MonoBehaviour
{
    [SerializeField]
    private Vector3 targetLocation = Vector3.zero;

    [Range(1.0f, 10.0f), SerializeField]
    private float moveDuration = 1.0f;

    [SerializeField]
    private Ease moveEase = Ease.Linear;

    [SerializeField]
    private DoTweenType _doTweenType = DoTweenType.MovementOneWay;

    private enum DoTweenType
    {
        MovementOneWay
    }
    void Start()
    {
        if (_doTweenType == DoTweenType.MovementOneWay)
        {
            if(targetLocation == Vector3.zero)
            {
                targetLocation = transform.position;
            }
        }
    }


}
