using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Pause : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void onClick () {
	
		if (!EventSystem.current.IsPointerOverGameObject())
		Time.timeScale = 0f;
	}
}
