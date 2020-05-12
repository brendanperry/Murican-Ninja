using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndScreenScore : MonoBehaviour {
	
	static float score = 0;
	static float highScore = 0;
	
	int scores = 0;
	
	void Start (){
		highScore = PlayerPrefs.GetInt ("highScore", 0);
		score = PlayerPrefs.GetInt ("score", 0);

		GameObject canvas = GameObject.Find ("Canvas");
		Text[] textValue = canvas.GetComponentsInChildren<Text> ();
		textValue [scores].text = "SCORE: " + (int)score + "\nHIGH SCORE: " + (int)highScore;
		
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