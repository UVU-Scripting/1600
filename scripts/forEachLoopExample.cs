using UnityEngine;
using System.Collections;

public class forEachLoopExample : MonoBehaviour
{

	// Use this for initialization
	void Start ()
{
		string[] strings = new string[7];

		strings[0] = "This is my Grocery List";
		strings[1] = "Milk";
		strings[2] = "Navel Oranges";
		strings[3] = "Cocoa Puffs Cereal";
		strings[4] = "Can of Black Beans";
		strings[5] = "Donuts";
	strings[6] = "Butter";
		foreach(string item in strings)
		{
				print (item);
		}
}
}
