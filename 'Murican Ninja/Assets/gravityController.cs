using UnityEngine;
using System.Collections;

public class gravityController : MonoBehaviour {

	public float jumpHeight; 
	public bool isJumping = false;  
	public float ConstantSpeed = 1f; 

	public float Speed = 4f;






	
	
	
	// Use this for initialization
	void Start () {


		GetComponent<Rigidbody2D>().gravityScale = 4f;
		
	}
	
	void FixedUpdate(){ 
		
		
		GetComponent<Rigidbody2D>().velocity = new Vector2 (ConstantSpeed, GetComponent<Rigidbody2D>().velocity.y);
		
		
	}
	
	
	void Update(){



			if (isJumping == false) {

				if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0)) {
				
					GetComponent<Rigidbody2D>().gravityScale *= -1;
					transform.Rotate (Vector3.right * 180);
					isJumping = true;


			}
		}
	}

	void OnCollisionEnter2D(Collision2D col) {
		
		if (col.gameObject.tag == "Ground")
			{
			isJumping = false;
			}
			else
			{
				isJumping = true;
		}
		
	}
}
