using UnityEngine;
using System.Collections;

public class allTogether : MonoBehaviour {

	int goombasNotSquished = 5;
	void Start () {
		Debug.Log ("Mario is going to get in a fight with five Goombas! Lets see if he will win!");
		while (goombasNotSquished >= 0)
		{
			if (goombasNotSquished > 1) {
			Debug.Log ("Mario squished a Goomba! There are " + goombasNotSquished + " remaining!");
			goombasNotSquished--;
			}
			else if (goombasNotSquished == 1) {
			Debug.Log ("Mario squished a Goomba! There is " + goombasNotSquished + " remaining!");
			goombasNotSquished--;
			}
			else if (goombasNotSquished == 0) {
			Debug.Log ("The Goomba Squished Mario! That sucks! There are " + goombasNotSquished + " Marios remaing. Game over");
			goombasNotSquished--;
			}
		}
		string[] groceryItems = new string[] {"1up Mushroom", "Fire Flowers", "Super Star", "Gumba Repelant",
			"Flying Feather", "Princess Perfume"};
		Debug.Log ("Now that Mario is dead, Peach needs to go to the store to buy a new 1up mushroom for" +
		           " him. Naturally she, as a woman, will buy more while she is there!");
		Debug.Log ("She is going to buy:");
		foreach (string groceryItem in groceryItems)
		{
			Debug.Log (groceryItem);
	}
}
}