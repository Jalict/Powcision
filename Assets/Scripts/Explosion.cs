using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {

	void Start () {
        StartCoroutine("Kill");
	}

    IEnumerator Kill()
    {
        yield return new WaitForSeconds(2); // Make this more flexiable for every particle (OR finder another solution)

        Destroy(gameObject);
    }
}
