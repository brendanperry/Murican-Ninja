using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GravScore : MonoBehaviour {

	static int Gscore = 0;
	static int GhighScore = 0;

	public static int points = 1;
	
	int scores = 0;
	
	void Start (){
		Gscore = 0;
		GhighScore = PlayerPrefs.GetInt ("GhighScore", 0);

	
		
	}
	
	static public void AddPoint (int points) {
		Gscore += points;
		if(Gscore > GhighScore) {
			GhighScore = Gscore;
		}
		
	}
	
	void OnDestroy(){
		
		PlayerPrefs.SetInt ("GhighScore", GhighScore);
		PlayerPrefs.SetInt ("Gscore", Gscore);
	}
	
	// Update is called once per frame
	void Update () {
		GameObject canvas = GameObject.Find ("Canvas");
		Text[] textValue = canvas.GetComponentsInChildren<Text> ();
		textValue [scores].text = " " + Gscore;
	}
}
