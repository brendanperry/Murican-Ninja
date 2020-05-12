using UnityEngine;
using System.Collections;

public class CameraFollowScript : MonoBehaviour {

	//Ninja = Player
	//You will need to drag the character controller to the camera in order for it to work
	
	public Transform player; 


	void Update () {

		transform.position = new Vector3 (player.position.x + 2, 0, -10);
	
	}
}
