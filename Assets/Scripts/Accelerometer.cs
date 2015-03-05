using UnityEngine;
using System.Collections;

public class Accelerometer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //TODO Look into this
        transform.rotation = Quaternion.LookRotation(Input.acceleration, Vector3.right);
	}
}
