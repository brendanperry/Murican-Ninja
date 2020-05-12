using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FrenzyEndScreen : MonoBehaviour {
	
	static int Fscore = 0;
	static int FhighScore = 0;
	
	int Fscores = 0;
	
	void Start (){
		FhighScore = PlayerPrefs.GetInt ("FhighScore", 0);
		Fscore = PlayerPrefs.GetInt ("Fscore", 0);
		
		GameObject canvas = GameObject.Find ("Canvas");
		Text[] textValue = canvas.GetComponentsInChildren<Text> ();
		textValue [Fscores].text = "FRENZY SCORE: " + Fscore + "\nFRENZY HIGH SCORE: " + FhighScore;
		
	}
	
	static public void AddPoint () {
		Fscore++;
		if(Fscore > FhighScore) {
			FhighScore = Fscore;
		}
		
	}
	
	void OnDestroy(){
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}