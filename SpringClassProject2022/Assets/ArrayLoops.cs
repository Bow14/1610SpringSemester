using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayLoops : MonoBehaviour
{
	public string[] peopleA = {"John", "Greg", "Pearson", "Caleb"};

	public int[] numberG = {2, 4, 5, 20, 45};
	private int numberB = 25;
	
	
	// Use this for initialization
	void Start () {
		foreach (var p in peopleA)
		{
			print(p);
		}

		while (numberG.Length > numberB )
		{
			print("Number G is just better");
			numberB++;

		}

		for (int i = 0; i < numberB; i++)
		{
			print(numberB);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
