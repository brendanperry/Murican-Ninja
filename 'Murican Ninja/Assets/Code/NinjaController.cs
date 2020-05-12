using UnityEngine;
using System.Collections;

public class NinjaController : MonoBehaviour {
	
	
	public float jumpHeight; 
	public bool isJumping = false;  
	public float ConstantSpeed = 1f; 
	
	
	
	
	// Use this for initialization
	void Start () {
		
		
	}
	
	void FixedUpdate(){ 
		
		
		GetComponent<Rigidbody2D>().velocity = new Vector2 (ConstantSpeed, GetComponent<Rigidbody2D>().velocity.y);
		
		
		
	}
	
	void Update(){
		
		
		if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0)) {
			
		}
		
		if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0)) {
			
			if (isJumping == false) {
				GetComponent<Rigidbody2D>().AddForce (Vector2.up * jumpHeight);
				isJumping = true;
			}
			
			
			{
				
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