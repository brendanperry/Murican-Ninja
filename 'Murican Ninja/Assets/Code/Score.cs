using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	static int score = 0;
	static int highScore = 0;

	int scores = 0;

	public static int points;

	void Start (){
		score = 0;
		highScore = PlayerPrefs.GetInt ("highScore", 0);

		          
	}

	static public void AddPoint (int points) {
		score+= points;
		if(score > highScore) {
			highScore = score;
		}
	
	}

	void OnDestroy(){

		PlayerPrefs.SetInt ("highScore", highScore);
		PlayerPrefs.SetInt ("score", score);
	}
	
	// Update is called once per frame
	void Update () {
		GameObject canvas = GameObject.Find ("Canvas");
		Text[] textValue = canvas.GetComponentsInChildren<Text> ();
		textValue [scores].text = " " + score;
	}
	}