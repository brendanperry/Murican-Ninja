using UnityEngine;
using System.Collections;

public class ColumnSpawnScript : MonoBehaviour {

	public GameObject[] obj;
	public float SpawnMin = 1f;
	public float SpawnMax = 1.5f;

	// Use this for initialization
	void Start () {

		Spawn (); 
	
	}

	void Spawn () {

		Instantiate(obj[Random.Range (0, obj.GetLength(0))], transform.position, transform.rotation); 
		Invoke ("Spawn", Random.Range (SpawnMin, SpawnMax)); { 
	
	}

	}
}
