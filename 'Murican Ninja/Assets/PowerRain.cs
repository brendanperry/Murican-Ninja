using UnityEngine;
using System.Collections;

public class PowerRain : MonoBehaviour {

	public AudioClip BurgerSound; 
	
	public float volume = .55f;

	public int point;
	
	void Start(){
		
	}
	
	void OnTriggerEnter2D(Collider2D collider)
	{
		if(collider.gameObject.tag == "Player"){
			RainScore.AddPoint(point);
			AudioSource.PlayClipAtPoint(BurgerSound, collider.transform.position, volume);
			Destroy(this.gameObject);
			
			
			
		}
	}
}