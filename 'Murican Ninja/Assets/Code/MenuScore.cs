using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScore : MonoBehaviour {
	
	static int score = 0;
	static int highScore = 0;
	
	int scores = 0;
	
	void Start (){
		highScore = PlayerPrefs.GetInt ("highScore", 0);

		GameObject canvas = GameObject.Find ("Canvas");
		Text[] textValue = canvas.GetComponentsInChildren<Text> ();
		textValue [scores].text ="\nHIGH SCORE: " + highScore;
		
	}
	
	static public void AddPoint () {
		score++;
		if(score > highScore) {
			highScore = score;
		}
		
	}
	
	void OnDestroy(){
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}