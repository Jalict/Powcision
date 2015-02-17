using UnityEngine;
using System.Collections;

public class CanonShoot : MonoBehaviour {
    public GameObject projectile;
    public GameObject spawnPos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        // PC Controls
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectile,spawnPos.transform.position,transform.rotation);
        }
	}
}
