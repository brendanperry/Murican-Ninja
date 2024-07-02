using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.Advertisements;
using UnityEngine.iOS;

public class EndScreenScore : MonoBehaviour {
	
	static int score = 0;
	static int highScore = 0;
	
	int scores = 0;
	
	void Start (){
		highScore = PlayerPrefs.GetInt ("highScore", 0);
		score = PlayerPrefs.GetInt ("score", 0);

		GameObject canvas = GameObject.Find ("Canvas");
		Text[] textValue = canvas.GetComponentsInChildren<Text> ();
		textValue [scores].text = "SCORE: " + (int)score + "\nHIGH SCORE: " + (int)highScore;

		Social.ReportScore(highScore, "normal", success => {
			Debug.Log(success ? "Reported score successfully" : "Failed to report score");
		});

		if (score > 50)
        {
			Device.RequestStoreReview();
		}
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