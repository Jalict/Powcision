using UnityEngine;
using System.Collections;
using System;

public class CameraController : MonoBehaviour {

    public GameObject camera;
    private GameObject ball;

	void Start () {
	    
	}
	
	void Update () {
        // If the ball exist, then follow it
        if (ball != null)
        {
            Vector3 pos;
            pos = ball.transform.localPosition;
            pos -= ball.rigidbody.velocity/4;   // Is this alright, or is there a better approach to this?
            camera.transform.position = pos;

            camera.transform.LookAt(ball.transform.position);
        }
        // If ball doesn't exist, go to canon position
        else
        {
            Debug.Log("Ball died, now what?!");
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
