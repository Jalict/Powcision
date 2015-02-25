using UnityEngine;
using System.Collections;

public class Destructable : MonoBehaviour {
    /*
     * Privat Variables
     */
    private AudioSource destructionSource;
    private AudioSource hitSource;
    private ParticleSystem destructionEffect;
    private ParticleSystem hitEffect;

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



	// Use this for initialization
	void Start () {
        destructionSource = gameObject.AddComponent<AudioSource>();
        hitSource = gameObject.AddComponent<AudioSource>();

        destructionSource.clip = destructionClip;
        hitSource.clip = hitClip;
	}

    public void Damage(int damageAmount)
    {
        health -= damageAmount;

        hitSource.Play();

        // If object have lost all health, then replace object with destroyed one.
        if (health <= 0)
        {
            destructionSource.Play();

            if(destructionPrefab != null)
                Instantiate(destructionPrefab, transform.position, transform.rotation);

            Destroy(gameObject);
        }
    }
}
