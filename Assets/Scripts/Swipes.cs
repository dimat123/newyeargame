using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Swipes : MonoBehaviour
{
    public Text SidesMove;

    public float maxSwipetime;
    public float minSwipeDistance;

    private float swipeStartTime;
    private float swipeEndTime;
    private float swipeTime;

    private Vector2 startSwipePosition;
    private Vector2 endSwipePosition;
    private float swipeLegth;

    // Update is called once per frame
    void Update()
    {
        SwipeTest();
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
        if (Distance.x > 0)
        {
            SidesMove.text = "R";
        }
        else if (Distance.x < 0)
        {
            SidesMove.text = "L";
        }
    }
}
