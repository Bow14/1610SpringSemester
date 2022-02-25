using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifstatmentTest : MonoBehaviour
{
	private int dayTime = 10;
	private int middleTime = 5;
	private int nightTime = 12;
	private int dayChange = 8;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			//DayTest();

			var dayChange = Time.deltaTime * 2;
		}

		{
			if (dayTime < middleTime)
			{
				print("Its too early for this");
			}else if (dayTime > middleTime)
			{
				print("It is a perfect time for a walk");
			}
			else if (middleTime > nightTime) ;

			{
				print("It is too late for this");
			}
		}
	}

	
}
