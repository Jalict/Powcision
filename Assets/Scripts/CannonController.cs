using UnityEngine;
using System.Collections;

//TODO Merge this with CanonShoot.cs

public class CannonController : MonoBehaviour {
    [Header("Settings")]
    public float rotationSpeed;

    [Header("Pointers")]
    public Transform barrel;
    public GameObject projectile;
    public GameObject spawnPos;

	void Start () 
    {
	}

	void Update () {

		// PC Controls
        // Movement
		if (Input.GetKey (KeyCode.A)) 
        {
			transform.Rotate(Vector3.forward, -rotationSpeed * Time.deltaTime, Space.Self);
		}
		if (Input.GetKey (KeyCode.D)) 
        {
            transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime, Space.Self);
		}
        if (Input.GetKey(KeyCode.W))
        {            
            barrel.Rotate(Vector3.right, -rotationSpeed * Time.deltaTime, Space.Self);
        }
        if (Input.GetKey(KeyCode.S))
        {
            barrel.Rotate(Vector3.right, rotationSpeed * Time.deltaTime, Space.Self);
        }

        // Firing
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectile, spawnPos.transform.position, spawnPos.transform.rotation);
        }

        Debug.DrawRay(spawnPos.transform.position, spawnPos.transform.forward, Color.magenta);
	}
}
