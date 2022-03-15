using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class onTrigger : MonoBehaviour
{
	public UnityEvent purpose;

	private void OnTriggerExit(Collider other)
	{
		Debug.Log("Why leave my warm embrace");
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
