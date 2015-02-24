using UnityEngine;
using System.Collections;

public class Destructable : MonoBehaviour {
    /*
     * Privat Variables
     */
    private AudioSource destructionSource;
    private AudioSource hitSource;


    /*
     * Public Variables
     */
	[Header("Prop Information")]
	public string name;
	public int health;

    [Header("Sound Clips")]
    public AudioClip destructionClip;
    public AudioClip hitClip;

	[Header("Pointers")]
	public GameObject destructionPrefab;


	// Use this for initialization
	void Start () {
        destructionSource = gameObject.AddComponent<AudioSource>();
        hitSource = gameObject.AddComponent<AudioSource>();

        destructionSource.clip = destructionClip;
        hitSource.clip = hitClip;
	}
	
	// Update is called once per frame
	void Update () {

		// If object have lost all health, then replace object with destroyed one.
		if (health <= 0) {
            destructionSource.Play();

			Instantiate(destructionPrefab,transform.position,transform.rotation);

			Destroy(gameObject);
		}
	}

    public void Damage(int damageAmount)
    {
        health -= damageAmount;

        hitSource.Play();
    }
}
