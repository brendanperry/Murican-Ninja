using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

	public void ChangeScene(string Restart){
		Application.LoadLevel (Restart);
	
	}
}
