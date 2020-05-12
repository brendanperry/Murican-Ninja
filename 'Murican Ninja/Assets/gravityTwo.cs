using UnityEngine;
using System.Collections;

public class gravityTwo : MonoBehaviour {

	
	//public float jumpHeight; 
	public bool isJumping = false;  
	public float ConstantSpeed = 1f; 
	
	public GameObject NinjaOne;
	
	
	
	
	// Use this for initialization
	void Start () {
		
		
	}
	
	void FixedUpdate(){ 
		
		
		GetComponent<Rigidbody2D>().velocity = new Vector2 (ConstantSpeed, GetComponent<Rigidbody2D>().velocity.y);
		
		
		
	}
	
	void Update(){
		
		NinjaOne.transform.position = gameObject.transform.position;
		
		
		if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0)) {
			
		}
		
		if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0)) {
			
			if (isJumping == false) {
				//NinjaTwo.GetComponent<SpriteRenderer>().enabled = true;
				//NinjaTwo.GetComponent<Rigidbody2D>().isKinematic = false;
				//NinjaTwo.GetComponent<gravityController>().enabled = true;
				
				//NinjaOne.GetComponent<SpriteRenderer>().enabled = false;
				//NinjaOne.GetComponent<Rigidbody2D>().isKinematic = true;
				//NinjaOne.GetComponent<gravityController>().enabled = false;
				
				NinjaOne.GetComponent<SpriteRenderer>().enabled = true;
				gameObject.GetComponent<SpriteRenderer>().enabled = false;
			}
			
		}
	}
	
	
	
	void OnCollisionEnter2D(Collision2D col) {
		
		if (col.gameObject.tag == "Ground") {
			isJumping = false;{
			}
			
		}
		
	}
}