using UnityEngine;
using System.Collections;
using System;

public class CameraController : MonoBehaviour {
    private GameObject ball;
	
	void Update () {
        // If the ball exist, then follow it
        if (ball != null)
        {
            Vector3 pos;
            pos = ball.transform.localPosition;

            if (ball.rigidbody.velocity.y <= 0)
            {
                pos -= ball.rigidbody.velocity / 4;   //TODO Lerp this
            }
            
            gameObject.transform.position = pos;

            gameObject.transform.LookAt(ball.transform.position);
        }
        // If ball doesn't exist, go to canon position
        else
        {
            /*GameObject obj = GameObject.Find("Canon-barrel");
            Vector3 pos = obj.transform.position;
            pos.y += 2;
            gameObject.transform.position = pos;
            gameObject.transform.rotation = obj.transform.rotation;*/
        }
	}

    /*
     * Whenever a new ball is fired, 
     * this function should be called and give the camera a pointer to that ball
     */
    public void SetBall(GameObject ball)
    {
        this.ball = ball;
    }
}
