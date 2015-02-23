using UnityEngine;
using System.Collections;

//TODO Merge this with CanonAim.cs

public class CanonShoot : MonoBehaviour {

    public GameObject projectile;
    public GameObject spawnPos;

	void Start () {
	
	}
	
	void Update () {
        // PC Controls
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectile, spawnPos.transform.position, spawnPos.transform.rotation);
        }

        Debug.DrawRay(spawnPos.transform.position, spawnPos.transform.forward, Color.magenta);
	}
}
