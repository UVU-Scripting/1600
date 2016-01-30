using UnityEngine;
using System.Collections;

public class groceryListExample : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string[] thisIsMyGroceryList = new string[6];
		//array of 6 items
		thisIsMyGroceryList[0] = "Milk";
		thisIsMyGroceryList[1] = "Navel Oranges";
		thisIsMyGroceryList[2] = "Coco Puffs Cereal";
		thisIsMyGroceryList[3] = "Can of Black Beans";
		thisIsMyGroceryList[4] = "Donuts";
		thisIsMyGroceryList[5] = "Butter";
		
		foreach (string item in thisIsMyGroceryList) 
		{
			print (item);
		}
	}

}
