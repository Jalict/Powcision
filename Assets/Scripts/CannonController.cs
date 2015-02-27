using UnityEngine;
using System.Collections;

//TODO Merge this with CanonShoot.cs

public class CannonController : MonoBehaviour {
    public float rotationSpeed;

    public Transform barrel;

	void Start () 
    {
	}

	void Update () {

		// PC Controls
		if (Input.GetKey (KeyCode.A)) 
        {
			transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.Self);
		}
		if (Input.GetKey (KeyCode.D)) 
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime, Space.Self);
		}
        if (Input.GetKey(KeyCode.W))
        {            
            barrel.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            barrel.Rotate(Vector3.right, - rotationSpeed * Time.deltaTime);
        }
	}
}
