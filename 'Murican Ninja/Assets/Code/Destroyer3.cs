using UnityEngine;
using System.Collections;

public class Destroyer3 : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.tag == "Player") {
			Application.LoadLevel("ScoreScreen 2");
			return;
		}
		
		if (other.gameObject.transform.parent) {
			Destroy (other.gameObject.transform.parent.gameObject); 
		} else {
			
			Destroy (other.gameObject);
		}
	}
	
}
