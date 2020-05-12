using UnityEngine;
using System.Collections;



public class FrenzyPoint : MonoBehaviour {
	
	public AudioClip BurgerSound; 
	
	float volume = .15f;

	public int point = 1;

	void Start(){
		
	}
	
	void OnTriggerEnter2D(Collider2D collider)
	{
		if(collider.gameObject.tag == "Player"){
			FrenzyScore.AddPoint(point); 
			AudioSource.PlayClipAtPoint(BurgerSound, new Vector3 (5, 1,2), volume);
			Destroy(this.gameObject);
			
			
			
		}
	}
}