using UnityEngine;
using System.Collections;

public class whileLoop : MonoBehaviour {
	int goombaCount = 11;
	// Use this for initialization
	void Start ()
	{
		while (goombaCount > 0) 
		{
			Debug.Log("One Goomba has been smashed! Goomba count " + goombaCount);
			goombaCount--;

		}
		{
			bool shouldContinue = false;
		
			do 
			{
				print ("All the Goombas are smashed...Go Mario!");
			} 
			while (shouldContinue == true);
		}
	}
}
