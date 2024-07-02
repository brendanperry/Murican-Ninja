using UnityEngine;
using System.Collections;

public class MenuToInfo : MonoBehaviour {

    public void Start()
    {
		Social.localUser.Authenticate(ProcessAuthentication);
	}

	// Use this for initialization
	public void ChangeToScene (string LoadLevel) {
		Application.LoadLevel ("InfoScene");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void ProcessAuthentication(bool success)
	{
		if (success)
		{
			Debug.Log("Authenticated, checking achievements");
		}
		else
		{
			Debug.Log("Failed to authenticate");
		}
	}
}
