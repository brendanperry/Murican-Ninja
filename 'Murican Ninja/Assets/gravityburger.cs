using UnityEngine;
using System.Collections;

public class gravityburger : MonoBehaviour {

	public AudioClip BurgerSound; 
	
	public float volume = .55f;

	public int point = 1;
	
	void Start(){
		
	}
	
	void OnTriggerEnter2D(Collider2D collider)
	{
		if(collider.gameObject.tag == "Player"){
			GravScore.AddPoint(point);
			AudioSource.PlayClipAtPoint(BurgerSound, new Vector3 (5, 1,2), volume);
			Destroy(this.gameObject);
			
			
			
		}
	}
}