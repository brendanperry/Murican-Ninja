using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndGravityScore : MonoBehaviour {
	
	static int Gscore = 0;
	static int GhighScore = 0;
	
	int Gscores = 0;
	
	void Start (){
		GhighScore = PlayerPrefs.GetInt ("GhighScore", 0);
		Gscore = PlayerPrefs.GetInt ("Gscore", 0);
		
		GameObject canvas = GameObject.Find ("Canvas");
		Text[] textValue = canvas.GetComponentsInChildren<Text> ();
		textValue [Gscores].text = "GRAVITY SCORE: " + Gscore + "\nGRAVITY HIGH SCORE: " + GhighScore;
		
	}
	
	static public void AddPoint () {
		Gscore++;
		if(Gscore > GhighScore) {
			GhighScore = Gscore;
		}
		
	}
	
	void OnDestroy(){
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}