using UnityEngine;
using System.Collections;

public class groceryList : MonoBehaviour {

	void Start () {
	string[] groceryItems = new string[] {"1up Mushroom", "Fire Flowers", "Super Star", "Gumba Repelant",
			"Flying Feather", "Princess Perfume"};
		foreach (string groceryItem in groceryItems)
		{
			Debug.Log (groceryItem);
		}
	}
}