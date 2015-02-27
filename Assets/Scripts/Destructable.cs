using UnityEngine;
using System.Collections;

public class Destructable : MonoBehaviour {
    /*
     * Privat Variables
     */
    private AudioSource destructionSource;
    private AudioSource hitSource;
    private ParticleSystem ps;

    /*
     * Public Variables
     */
    [Header("Prop Information")]
    public string name;
    public int health;

    [Header("Sound Clips")]
    public AudioClip destructionClip;
    public AudioClip hitClip;

	[Header("DestructionFX")]
	public GameObject destructionPrefab;
    public ParticleSystem destructionEffect;
    public ParticleSystem hitEffect;

	// Use this for initialization
	void Start () {
        // Sound Source & Clip
        destructionSource = gameObject.AddComponent<AudioSource>();
        hitSource = gameObject.AddComponent<AudioSource>();
        destructionSource.clip = destructionClip;
        hitSource.clip = hitClip;
	}

    public void Damage(int damageAmount)
    {
        health -= damageAmount;

        hitSource.Play();
        Instantiate(hitEffect,transform.position,Quaternion.identity); // Spawn at hit pos instead

        if (health <= 0)  // If object have lost all health, then replace object with destroyed one.
        {
            destructionSource.Play();

            if(destructionPrefab != null)
                Instantiate(destructionPrefab, transform.position, transform.rotation);

            Destroy(gameObject);
        }
    }
}
