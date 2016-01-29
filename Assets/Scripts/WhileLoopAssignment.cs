using UnityEngine;
using System.Collections;

public class WhileLoopAssignment : MonoBehaviour 
{

	int Goombas = 12;

	void Start()
	{

		while (Goombas > 0 )
		{
			Goombas --;
			Debug.Log("One Goomba has been smashed! Goomba count " + Goombas);

		}
		print ("All the Goombas are smashed...Go Mario!");
	}
}
