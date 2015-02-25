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
        rigidbody.AddForce(transform.forward * firingMagnitude, ForceMode.VelocityChange);

        // TODO Create a pointer instead
        GameObject.Find("CameraController").GetComponent<CameraController>().SetBall(gameObject);
	}
    void OnCollisionEnter(Collision obj)
    {
        // Play Explosion Sound (Might consider that I'll play more sounds from this source!)
        GetComponent<AudioSource>().Play(); 

        DamageObjectsNearby(explosionRadius);
        // Going to look through objects nearby twice O(n*2), bad idea or OK? 
        AddForceToNearby(explosionRadius, explosionMagnitude);

        Destroy(gameObject);
    }

    private void DamageObjectsNearby(float radius)
    {
        Collider[] nearbyObjects = Physics.OverlapSphere(transform.position, radius);

        foreach (Collider obj in nearbyObjects)
        {
            Destructable hitObj = obj.GetComponent<Destructable>();
            if (hitObj != null)
            {
                hitObj.Damage(100); //TODO Calculate damage
            }
        }
    }

    private void AddForceToNearby(float radius, float magnitude)
    {
        Instantiate(explosion,transform.position,Quaternion.identity);

        Collider[] nearbyObjects = Physics.OverlapSphere(transform.position, radius);

        foreach (Collider obj in nearbyObjects)
        {
            if (obj.rigidbody != null)
            {
                obj.rigidbody.AddExplosionForce(magnitude, transform.position, radius);
            }
        }
    }
}
