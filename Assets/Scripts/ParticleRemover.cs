using UnityEngine;
using System.Collections;

public class ParticleRemover : MonoBehaviour {

	void Start () {
        // This might not be the best solution.
        // CON: This script should be added when the particle Plays. If not, it's not correctly timed.
        StartCoroutine("Kill");
	}

    IEnumerator Kill()
    {
        yield return new WaitForSeconds(gameObject.GetComponent<ParticleSystem>().startLifetime);

        Destroy(gameObject);
    }
}
