using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeScript : MonoBehaviour
{

    Vector2 startPos, endPos, direction;
    float startTime, endTime, timeInterval;

    // Update is called once per frame
    void Update()
    {


        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTime = Time.time;
            startPos = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTime = Time.time;
            timeInterval = startTime - endTime;
            endPos = Input.GetTouch(0).position;
            direction = startPos - endPos;

            GetComponent<Rigidbody2D>().AddForce(direction/timeInterval * 0.15f); 
        }

    }
}
