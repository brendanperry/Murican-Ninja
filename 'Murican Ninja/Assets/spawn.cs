using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {

	public GameObject ninja;
	Vector3 position = new Vector3(-1,-1,8);

	// Use this for initialization
	void Start () {

		ninja = Instantiate(ninja);
		ninja.transform.position = position;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
