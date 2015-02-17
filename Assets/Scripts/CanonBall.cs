using UnityEngine;
using System.Collections;

public class CanonBall : MonoBehaviour {
    public float magnitude;

	void Start () 
    {
        // Fire!
        rigidbody.AddForce(-transform.forward * magnitude * Time.deltaTime, ForceMode.VelocityChange);
	}
	
	void Update () 
    {

	}

    void OnCollisionEnter(Collision obj)
    {
        Explode();
    }

    void Explode()
    {
        Collider[] nearbyObjects = Physics.OverlapSphere(transform.position, 3);

        foreach (Collider obj in nearbyObjects)
        {
            if (obj.rigidbody != null)
            {
                obj.rigidbody.AddExplosionForce(1000, transform.position, 3);
            }
        }
    }
}
