using UnityEngine;
using System.Collections;

public class whileLoopGoomba : MonoBehaviour 
{
	string intro = "There are 12 Goombas and Mario is going to smash them all!";
	string victory = "All the Goombas are smashed...Go Mario!";
	int goombasRemaining = 12;
	int goombasSmashed = 1;
	// Use this for initialization
	void Start () 
	{
		Debug.Log (intro);
		while (goombasRemaining > 0) 
		{
			goombasRemaining --;
			Debug.Log (goombasSmashed + " goomba has been smashed! Goomba count is " + goombasRemaining);
			goombasSmashed ++;
		}
		Debug.Log (victory);
	}
}
