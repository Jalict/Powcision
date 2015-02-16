using UnityEngine;
using System.Collections;

public class CanonAim : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// PC Controls
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate(Vector3.back);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate(Vector3.forward);
		}
	}
}
