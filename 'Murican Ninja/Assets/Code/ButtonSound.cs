﻿using UnityEngine;
using System.Collections;

public class ButtonSound : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void PlayAudio () {

		GetComponent<AudioSource>().Play ();

	}
}