using UnityEngine;
using System.Collections;

public class ForEachLoopAssignment : MonoBehaviour 
{   
	void Start () 
	{

		//Debug.Log ("This is my grocery list");

		string[] list = new string[7];
/*		
  		Grocery List of 6 items and stating this is my grocery list, because writing Debug.Log ("This is my grocery list"); made it look 
		different than the assignment, but I think it would look better that way and not having "This is my grocery list as part of 
		the list itself.
*/
		list [0] = "This is my grocery list";
		list [1] = "Milk";
		list [2] = "Naval Oranges";
		list [3] = "Cocoa Puffs cereal";
		list [4] = "Can of black beans";
		list [5] = "Donuts";
		list [6] = "Butter";

		foreach (string item in list) 
		{
			print (item);
		}
	}
}