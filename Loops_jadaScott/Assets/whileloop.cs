using UnityEngine;
using System.Collections;

public class whileloop : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		string[] strings = new string[13];
		//array of 4 items
		strings[0] ="One Goomba has been smashed! Goomba count 11";
		strings[1] ="One Goomba has been smashed! Goomba count 10";
		strings[2] ="One Goomba has been smashed! Goomba count 9";
		strings[3] ="One Goomba has been smashed! Goomba count 8";
		strings[4] ="One Goomba has been smashed! Goomba count 7";
		strings[5] ="One Goomba has been smashed! Goomba count 6";
		strings[6] ="One Goomba has been smashed! Goomba count 5";
		strings[7] ="One Goomba has been smashed! Goomba count 4";
		strings[8] ="One Goomba has been smashed! Goomba count 3";
		strings[9] ="One Goomba has been smashed! Goomba count 2";
		strings[10] ="One Goomba has been smashed! Goomba count 1";
		strings[11] ="One Goomba has been smashed! Goomba count 0";
		strings[12] ="All the Goombas are smashed...Go Mario!";

		foreach (string item in strings) 
		{
			print (item);
		}
	}


}
