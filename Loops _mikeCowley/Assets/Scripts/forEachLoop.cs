using UnityEngine;
using System.Collections;

public class forEachLoop : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string[] strings = new string[6];
		//array of 4 items
		print ("This is my Grocery List");
		strings [0] = "Milk";
		strings [1] = "Navel Oranges";
		strings [2] = "Cocoa Puffs Cereal";
		strings [3] = "Can of Black Beans";
		strings [4] = "Donuts";
		strings [5] = "Butter";

		foreach (string item in strings) {
			print (item);
		}
	}
}
