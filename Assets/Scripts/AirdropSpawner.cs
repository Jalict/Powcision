using UnityEngine;
using System.Collections;

public class AirdropSpawner : MonoBehaviour {
    /*
     * Public
     */
    [Header("Spawner")]
    public GameObject objectToSpawn; //TODO Find better name
    public int width, height, depth;
    public bool enabled;

    [Header("Spawned Object")]
    public float fallSpeed;

    /*
     * Private
     */
    private float timeToSpawn;

	void Start () {
        StartCoroutine("WaitForDrop");
	}

    IEnumerator WaitForDrop()
    {
        while (enabled)
        {
            yield return new WaitForSeconds(timeToSpawn);

            float x = Random.Range(transform.position.x - (width / 2), transform.position.x + (width / 2)); 
            float z = Random.Range(transform.position.z - (depth / 2), transform.position.z + (depth / 2));
            float y = transform.position.y + (height/2); // Look into spawning this super high - Could look better!

            Instantiate(objectToSpawn, new Vector3(x, y, z), Quaternion.identity); //TODO Random rotate around y-axis
        }
    }

    void OnDrawGizmosSelected()
    {
        // Draw Spawning Area
        Vector3 center = new Vector3(transform.position.x,transform.position.y,transform.position.z);
        Vector3 size = new Vector3(width, depth, height);
        Gizmos.DrawWireCube(center, size);
    }
}
