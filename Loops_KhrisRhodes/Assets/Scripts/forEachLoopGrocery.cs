using UnityEngine;
using System.Collections;

public class forEachLoopGrocery : MonoBehaviour 
{
	string intro = "This is my shopping list.";
	string theEnd = "Gonna have a good breakfast tomorrow!";
	// Use this for initialization
	void Start () 
	{
		print(intro);

		string[] groceryList = new string[6];
		groceryList [0] = "Milk";
		groceryList [1] = "Orange juice";
		groceryList [2] = "Coco Puffs";
		groceryList [3] = "Eggs";
		groceryList [4] = "Donuts";
		groceryList [5] = "Bacon";

		foreach (string item in groceryList) 
		{
			print (item);
		}

		print(theEnd);
	}
}
