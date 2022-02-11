using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActivateScript : MonoBehaviour
{
	public UnityEvent line;

	private void OnCollisionEnter(Collision other)
	{
		Input.GetKey(KeyCode.E);
		print("Press G,B,Y for a color change!");
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
