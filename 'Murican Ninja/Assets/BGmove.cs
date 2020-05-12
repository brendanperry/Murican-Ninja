using UnityEngine;
using System.Collections;

public class BGmove : MonoBehaviour {
	
	public float speed = .05f;
	
	void Update(){
		
		GetComponent<Renderer>().material.mainTextureOffset = new Vector2 (Time.time * speed, 0f);
	}
}