using UnityEngine;
using System.Collections;

public class goombaCrush : MonoBehaviour {

	int goombasNotSquished = 5;
	void Start () {
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
	}	
}

