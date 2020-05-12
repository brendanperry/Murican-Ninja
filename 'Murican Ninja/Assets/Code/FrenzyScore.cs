using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FrenzyScore : MonoBehaviour {
	
	static int Fscore = 0;
	static int FhighScore = 0;

	public static int points;
	
	int Fscores = 0;
	
	void Start (){
		Fscore = 0;
		FhighScore = PlayerPrefs.GetInt ("FhighScore", 0);
		
		
	}
	
	static public void AddPoint (int points) {
		Fscore+= points;
		if(Fscore > FhighScore) {
			FhighScore = Fscore;
		}
		
	}
	
	void OnDestroy(){
		
		PlayerPrefs.SetInt ("FhighScore", FhighScore);
		PlayerPrefs.SetInt ("Fscore", Fscore);
	}
	
	// Update is called once per frame
	void Update () {
		GameObject canvas = GameObject.Find ("Canvas");
		Text[] textValue = canvas.GetComponentsInChildren<Text> ();
		textValue [Fscores].text = " " + Fscore;
	}
}