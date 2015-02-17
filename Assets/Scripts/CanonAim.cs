using UnityEngine;
using System.Collections;

public class CanonAim : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void Update () {

		// PC Controls
		if (Input.GetKey (KeyCode.A)) 
        {
            // None of these Vectors makes sense, why? Rotated in Blender?
            // TODO Take deltaTime into account
			transform.Rotate(Vector3.back);
		}
		if (Input.GetKey (KeyCode.D)) 
        {
            // None of these Vectors makes sense, why? Rotated in Blender?
            // TODO Take deltaTime into account
			transform.Rotate(Vector3.forward); 
		}
        if (Input.GetKey(KeyCode.W))
        {
            // None of these Vectors makes sense, why? Rotated in Blender?
            // TODO Take deltaTime into account
            transform.FindChild("Canon-barrel").Rotate(Vector3.right);
        }
        if (Input.GetKey(KeyCode.S))
        {
            // None of these Vectors makes sense, why? Rotated in Blender?
            // TODO Take deltaTime into account
            transform.FindChild("Canon-barrel").Rotate(Vector3.left);
        }
	}
}
