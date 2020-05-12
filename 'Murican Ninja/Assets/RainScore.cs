using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RainScore : MonoBehaviour {

	static int Rscore = 0;
	static int RhighScore = 0;
	
	int Rscores = 0;

	public static int points =1;
	
	void Start (){
		Rscore = 0;
		RhighScore = PlayerPrefs.GetInt ("RhighScore", 0);
		
		
	}
	
	static public void AddPoint (int points) {
		Rscore+= points;
		if(Rscore > RhighScore) {
			RhighScore = Rscore;
		}
		
	}
	
	void OnDestroy(){
		
		PlayerPrefs.SetInt ("RhighScore", RhighScore);
		PlayerPrefs.SetInt ("Rscore", Rscore);
	}
	
	// Update is called once per frame
	void Update () {
		GameObject canvas = GameObject.Find ("Canvas");
		Text[] textValue = canvas.GetComponentsInChildren<Text> ();
		textValue [Rscores].text = " " + Rscore;
	}
}