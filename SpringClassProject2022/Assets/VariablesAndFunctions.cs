using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
	private int theInt = 20; //Variable that is used for future scripts to achieve said assigned things

	// Use this for initialization
	void Start ()
	{
		theInt = machineFunction(theInt);
		Debug.Log(theInt);

	}
	
	// Update is called once per frame
	int machineFunction(int number) //Fucntion that takes in process to do an action
	{
		int result;
		result = number * 5;
		return result;
	}
}
