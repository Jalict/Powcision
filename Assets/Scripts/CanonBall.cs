using UnityEngine;
using System.Collections;

public class CanonBall : MonoBehaviour {
    public float magnitude;

	// Use this for initialization
	void Start () 
    {
        rigidbody.AddForce(Vector3.forward * magnitude * Time.deltaTime, ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update () 
    {
	    
	}
}
