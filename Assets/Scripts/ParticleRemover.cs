using UnityEngine;
using System.Collections;

public class ParticleRemover : MonoBehaviour {

	void Start () {
        // This might not be the best solution.
        // It won't spend time on updating and check for shit - So is this actually better to use a corutine instead?
        StartCoroutine("Kill");
	}

    IEnumerator Kill()
    {
        yield return new WaitForSeconds(gameObject.GetComponent<ParticleSystem>().startLifetime);

        Destroy(gameObject);
    }
}
