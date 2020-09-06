using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipes : MonoBehaviour
{

    float dir = 1;
    public float speed;
    public float jumpHeight;
    private Rigidbody2D playerRB;
    bool facingRight = true;

    public float maxSwipetime;
    public float minSwipeDistance;

    private float swipeStartTime;
    private float swipeEndTime;
    private float swipeTime;

    private Vector2 startSwipePosition;
    private Vector2 endSwipePosition;
    private float swipeLegth;

    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerRB.velocity = new Vector2(dir * speed * Time.deltaTime, playerRB.velocity.y);
        PlayerController();
        PlayerJump();
        SwipeTest();
    }
    void PlayerController()
    {
        if (Input.GetKeyDown(KeyCode.A) && facingRight == true)
        {
            FlipAndMove();
        }
        else if (Input.GetKeyDown(KeyCode.D) && facingRight == false)
        {
            FlipAndMove();
        }
    }
    void PlayerJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRB.velocity = Vector2.up * jumpHeight * Time.deltaTime;
        }
    }
    void FlipAndMove()
    {
        dir = -dir;
        transform.Rotate(0, 180, 0);
        facingRight = !facingRight;
    }
    void SwipeTest()
    {
        Debug.Log(Input.touchCount);
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                swipeStartTime = Time.time;
                startSwipePosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                swipeEndTime = Time.time;
                endSwipePosition = touch.position;
                swipeTime = swipeEndTime - swipeStartTime;
                swipeLegth = (endSwipePosition - startSwipePosition).magnitude;
                if (swipeTime < maxSwipetime && swipeLegth > minSwipeDistance)
                {
                    swipeControl();
                }
            }

        }
    }
        void swipeControl()
        {
            Vector2 Distance = endSwipePosition - startSwipePosition;
            float xDistance = Mathf.Abs(Distance.x);
            float yDistance = Mathf.Abs(Distance.y);
            if (xDistance > yDistance)
            {
                if (Distance.x > 0 && facingRight)
                {
                    FlipAndMove();
                }
                else if (Distance.x < 0 && facingRight)
                {
                    FlipAndMove();
                }
            }
            else if (yDistance > xDistance)
            {
                if (Distance.y > 0)
                {
                    playerRB.velocity = Vector2.up * jumpHeight * Time.deltaTime;
                }
                else if (Distance.y < 0)
                {
                    Debug.Log("SwipeRight");
                }
            }
        }
    }
