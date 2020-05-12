using UnityEngine;
using System.Collections;



public class PowerUP : MonoBehaviour {
	
	public AudioClip BurgerSound; 

	public float volume = .55f;

	public int point = 1;

	void Start(){

	}
	
	void OnTriggerEnter2D(Collider2D collider)
	{
		if(collider.gameObject.tag == "Player"){
			Score.AddPoint(point);
			AudioSource.PlayClipAtPoint(BurgerSound, collider.transform.position, volume);
				Destroy(this.gameObject);


			
		}
	}
}