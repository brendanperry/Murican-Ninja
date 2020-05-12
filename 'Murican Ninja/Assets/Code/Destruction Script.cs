using UnityEngine;
using System.Collections;

public class DestructionScript : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.tag == "Player") {
			Debug.Break ();
		}

		if (other.gameObject.transform.parent) {
			Destroy (other.gameObject.transform.parent.gameObject); 
		} else {

			Destroy (other.gameObject);
		}
	}

}
