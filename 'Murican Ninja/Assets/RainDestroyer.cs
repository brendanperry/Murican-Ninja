using UnityEngine;
using System.Collections;

public class RainDestroyer : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.tag == "Player") {
			Application.LoadLevel("ScoreScreen 3");
			return;
		}
		
		if (other.gameObject.transform.parent) {
			Destroy (other.gameObject.transform.parent.gameObject); 
		} else {
			
			Destroy (other.gameObject);
		}
	}
	
}
