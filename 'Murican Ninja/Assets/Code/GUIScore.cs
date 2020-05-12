using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GUIScore : MonoBehaviour {

	GUIScore txt; 

	public static int score = 0;
	public static int highScore = 0; 

	// Use this for initialization
	void Start () {

		//txt = gameObject.GetComponent<GUIScore> ();
		//txt.fix = "Score: " + score;
	
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	
	}

	public void IncreaseScore(int amount)
	{
		score += amount;
	}
}