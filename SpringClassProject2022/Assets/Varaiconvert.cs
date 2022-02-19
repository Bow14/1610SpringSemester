using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Varaiconvert : MonoBehaviour {
	// Ask user for fave number
	
	//Console.Write("Enter your favorite number!: ");

	// Turn that answer into an int
      
	// Attempt 1: use implicit conversion
	// int faveNumber = Console.ReadLine();
      
	// Attempt 2: use explicit conversion
	// int faveNumber = (int)Console.ReadLine();
      
	// Attempt 3: use Convert method
	int faveNumber = Convert.ToInt32(Console.ReadLine());

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
