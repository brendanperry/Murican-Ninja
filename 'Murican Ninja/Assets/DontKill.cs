using UnityEngine;
using System.Collections;

public class DontKill : MonoBehaviour {

	static bool AudioBegin = false; 
	
	void Awake()
	{
		if (!AudioBegin) {
			GetComponent<AudioSource>().Play ();
			DontDestroyOnLoad (gameObject);
			AudioBegin = true;
		} 
	}
	
	void Update () {
		if(Application.loadedLevelName == "firstmurica" || Application.loadedLevelName == "firstmurica 1" || Application.loadedLevelName == "firstmurica 2" || Application.loadedLevelName == "firstmurica 3" || Application.loadedLevelName == "firstmurica 4")
		{
			GetComponent<AudioSource>().Stop();
			AudioBegin = false;
		}
		
	}
}
