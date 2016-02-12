using UnityEngine;
using System.Collections;

public class whileLoopExample : MonoBehaviour {
	
	int goomba = 12;
	
	// Use this for initialization
	void Start () 
	{
		/*Pseudo Code

	while a variable is greater than 0 type out 
	One Goomba has been smashed! Goomba count i
	then reduce variable by one
	once the varible is less than 0 type out
	All the Goombas are smashed...Go Mario!

	*/
		while (goomba > 0) 
		{
			
			Debug.Log ("One Goomba has been smashed! Goomba Count " + goomba);
			goomba = goomba -1;
			
		}
		
		Debug.Log ("All the goombas are smashed...Go Mario!");
	}
	
	
}