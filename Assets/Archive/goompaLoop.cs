using UnityEngine;
using System.Collections;

public class goompaLoop : MonoBehaviour {

	int goombas = 12;
	// Use this for initialization
	void Start () 
	{
		while (goombas > 0) 
		{
			Debug.Log ("one goombas has been smashed!" + goombas);
			goombas --;
		}
		bool shouldContinue = false;
		do {
			print ("All goombas are smashed...Go Mario!");
		} 
		while(shouldContinue == true);
	}
}
