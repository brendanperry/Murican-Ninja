using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Mute : MonoBehaviour {

	public bool canMute;

	// Use this for initialization
	void Start () {
		canMute = true;
	
	}
	
	// Update is called once per frame
	void OnClick () {

		if (canMute) {
						AudioListener.pause = true;
						canMute = false;
				} else {
						AudioListener.pause = false;
						canMute = true;
				}
	
	}
}
