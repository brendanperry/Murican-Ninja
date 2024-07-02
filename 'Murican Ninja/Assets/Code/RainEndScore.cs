using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.iOS;

public class RainEndScore : MonoBehaviour {
	
	static int Rscore = 0;
	static int RhighScore = 0;
	
	int Rscores = 0;
	
	void Start (){
		RhighScore = PlayerPrefs.GetInt ("RhighScore", 0);
		Rscore = PlayerPrefs.GetInt ("Rscore", 0);
		
		GameObject canvas = GameObject.Find ("Canvas");
		Text[] textValue = canvas.GetComponentsInChildren<Text> ();
		textValue [Rscores].text = "RAIN SCORE: " + Rscore + "\nRAIN HIGH SCORE: " + RhighScore;

		Social.ReportScore(RhighScore, "rain", success => {
			Debug.Log(success ? "Reported score successfully" : "Failed to report score");
		});


		if (Rscore > 50)
		{
			Device.RequestStoreReview();
		}

	}
	
	static public void AddPoint () {
		Rscore++;
		if(Rscore > RhighScore) {
			RhighScore = Rscore;
		}
		
	}
	
	void OnDestroy(){
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}