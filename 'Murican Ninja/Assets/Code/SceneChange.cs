using UnityEngine;
using System.Collections;

public class SceneChange : MonoBehaviour {

	
	public void ChangeToMainMenu (string changeSceneTo) {
		Application.LoadLevel (changeSceneTo); 
	}
}
