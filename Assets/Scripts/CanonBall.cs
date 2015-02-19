using UnityEngine;
using System.Collections;

public class CanonBall : MonoBehaviour {
    public float firingMagnitude;
    public float explosionRadius;
    public float explosionMagnitude;

    public GameObject explosion;

	void Start () 
    {
        // Fire!
        rigidbody.AddForce(transform.forward * firingMagnitude * Time.deltaTime, ForceMode.VelocityChange);
	}
	
	void Update () 
    {

	}

    void OnCollisionEnter(Collision obj)
    {
        Explode();

        Destroy(gameObject);
    }

    void Explode()
    {
        Instantiate(explosion,transform.position,Quaternion.identity);

        Collider[] nearbyObjects = Physics.OverlapSphere(transform.position, explosionRadius);

        foreach (Collider obj in nearbyObjects)
        {
            if (obj.rigidbody != null)
            {
                obj.rigidbody.AddExplosionForce(explosionMagnitude, transform.position, explosionRadius);
            }
        }
    }
}
