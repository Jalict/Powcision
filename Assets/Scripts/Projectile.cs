using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
    [Header("Settings")]
    public float firingMagnitude;
    public float explosionRadius;
    public float explosionMagnitude;

    [Header("Effects")]
    public GameObject explosion;

    // Pointer
    private GameObject camera;

	void Start () 
    {
        // Fire!
        GetComponent<Rigidbody>().AddForce(transform.forward * firingMagnitude, ForceMode.VelocityChange);

        // Set current camera to be projectile
        CameraController.SetActiveCamera("Projectile Camera");

        // Get a pointer to the camera
        camera = CameraController.GetActiveCamera();
	}

    void OnCollisionEnter(Collision obj)
    {
        // Play Explosion Sound (Might consider that I'll play more sounds from this source!)
        GetComponent<AudioSource>().Play(); 

        DamageObjectsNearby(explosionRadius);
        // Going to look through objects nearby twice O(n*2), bad idea or OK? 
        AddForceToNearby(explosionRadius, explosionMagnitude);

        //TODO Do something with the camera so it stays a bit (Corutine?)

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
            if (obj.GetComponent<Rigidbody>() != null)
            {
                obj.GetComponent<Rigidbody>().AddExplosionForce(magnitude, transform.position, radius);
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        //TODO Draw Trajectory
        //... Or maybe not!
    }
}
