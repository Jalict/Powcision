using UnityEngine;
using System.Collections;

public class CannonController : MonoBehaviour {
    [Header("Settings")]
    public float rotationSpeed;

    [Header("Pointers")]
    public Transform barrel;
    public GameObject projectileToSpawn;
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
            barrel.Rotate(Vector3.right, rotationSpeed * Time.deltaTime, Space.Self);
        }
        if (Input.GetKey(KeyCode.S))
        {
            barrel.Rotate(Vector3.right, -rotationSpeed * Time.deltaTime, Space.Self);
        }

        // Firing
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject projectile = Instantiate(projectileToSpawn, spawnPos.transform.position, spawnPos.transform.rotation) as GameObject;
            CameraController.SetActiveCamera(projectile);
        }

        Debug.DrawRay(spawnPos.transform.position, spawnPos.transform.forward, Color.magenta);
	}
}
