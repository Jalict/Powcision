using UnityEngine;
using System.Collections;

public class Targets : MonoBehaviour {
	[Header("Prop Information")]
	public string name;
	public int health;

	[Header("Destruction")]
	public GameObject destructionPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// If object have lost all health, then replace object with destroyed one.
		if (health <= 0) {
			Instantiate(destructionPrefab,transform.position,transform.rotation);

			Destroy(gameObject);
		}
	}
}
