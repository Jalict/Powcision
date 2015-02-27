using UnityEngine;
using System.Collections;

public class RotationVectors : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.forward);
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, transform.up);
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(transform.position, transform.right);
    }
}
