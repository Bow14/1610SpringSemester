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
			if (Color.green = new Color())
			{
				Console.WriteLine("Wow super Green");
			}
		}
		if (Input.GetKeyDown(KeyCode.B))
		{
			GetComponent<Renderer>().material.color = Color.black;
			
		}

		if (Input.GetKeyDown(KeyCode.Y))
		{
			GetComponent<Renderer>().material.color = Color.yellow;
		}
	}
}
