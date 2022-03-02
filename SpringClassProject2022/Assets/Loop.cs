using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
	private int mathSub = 20;
	

	// Use this for initialization
	void Start () {
		while (mathSub < 39)
		{
			print(mathSub);
			mathSub++;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
