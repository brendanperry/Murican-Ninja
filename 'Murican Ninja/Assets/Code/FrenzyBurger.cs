using UnityEngine;
using System.Collections;

public class FrenzyBurger : MonoBehaviour {

	public AudioClip BurgerSound; 
	
	float volume = .25f;

	public int point = 1;

	
	void Start(){
		
	}
	
	void OnTriggerEnter2D(Collider2D collider)
	{
		if(collider.gameObject.tag == "Player"){
			Score.AddPoint(point); 
			AudioSource.PlayClipAtPoint(BurgerSound, new Vector3 (5, 1,2), volume);
			Destroy(this.gameObject);
			
			
			
		}
	}
}