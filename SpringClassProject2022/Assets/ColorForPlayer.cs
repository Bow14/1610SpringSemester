using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorForPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}



	void Update()
	{
		if (Input.GetKeyDown(KeyCode.G))
		{
			GetComponent<Renderer> ().material.color = Color.green;
			bool isGreen = true;

			Debug.Log("Glad your green Bro!");
			
		}
		
		if (Input.GetKeyDown(KeyCode.B))
		{
			GetComponent<Renderer>().material.color = Color.black;
			Debug.Log("Welcome to the true faction");
			

		}

		if (Input.GetKeyDown(KeyCode.Y))
		{
			GetComponent<Renderer>().material.color = Color.yellow;
			Debug.Log("Yellow will prove to be dominate");
			
		}
	}
}
