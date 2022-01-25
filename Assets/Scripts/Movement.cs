using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //private static Movement instance = null;

    public static float speed = 750;
    private bool _isMoving;
    public static bool canStop = true;
    [SerializeField] private float _lerpSpeed = 5;

    SwerveInputSystem swerveInput;
    Rigidbody rb;

    [SerializeField] private float swerveSpeed;
    [SerializeField] private float maxSwerveAmount;


    //public static Movement Instance
    //{
    //    get
    //    {
    //        return instance;
    //    }
    //}

    //private void Awake()
    //{
    //    if (instance != null && instance != this)
    //    {
    //        Destroy(this.gameObject);
    //    }

    //    instance = this;
    //    DontDestroyOnLoad(this.gameObject);
    //}
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        swerveInput = GetComponent<SwerveInputSystem>();
        _isMoving = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (canStop && other.gameObject.tag.Equals("Stop"))
        {
            speed = 0;
            canStop = false;
        }
        if (other.gameObject.TryGetComponent(out BallCount bc) && other.gameObject.tag.Equals("LevelUp"))
        {
            bc.ballCount = 0;
            other.gameObject.tag = "Pool";
            bc._whichPool++;
            bc.goal = 5;
            bc.ballCountText.text = bc.ballCount.ToString() + "/" + bc.goal.ToString();
            Debug.Log("whichpool artacak");
        }
    }

    void FixedUpdate()
    {
        if (_isMoving == true)
        {
            Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;        //moving forward 
            Vector3 sideMove = transform.right * swerveSpeed * swerveInput.MoveFactorX * Time.fixedDeltaTime;
            rb.velocity = Vector3.Lerp(rb.velocity, sideMove + forwardMove, _lerpSpeed * Time.fixedDeltaTime);
        }
        
        else if (_isMoving == false)
        {
            speed = 0;
        }
    }
}
