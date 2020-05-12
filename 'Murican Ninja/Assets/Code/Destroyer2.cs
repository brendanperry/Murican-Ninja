using UnityEngine;
using System.Collections;

public class Destroyer2 : MonoBehaviour {

	public string scene;
	
	
	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.tag == "Player") {
			Destroy(other.gameObject);
			Application.LoadLevel(scene);
			return;
		}
		
		if (other.gameObject.transform.parent) {
			Destroy (other.gameObject.transform.parent.gameObject); 
		} else {
			
			Destroy (other.gameObject);
		}
	}
	
}
