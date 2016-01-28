using UnityEngine;
using System.Collections;

public class ForEachLoop : MonoBehaviour {

	// Use this for initialization
	void Start () {

		string[] groceryList = new string[] {"Milk", "Navel Oranges", "Cocoa Puffs Cereal",
												"Can of Black Beans", "Donuts", "Butter"};

		Debug.Log("This is my Grocery List");
		foreach (string grocery in groceryList) {
			Debug.Log(grocery);
		}
	}
}
