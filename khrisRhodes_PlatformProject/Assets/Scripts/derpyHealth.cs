using UnityEngine;
using System.Collections;

public class derpyHealth : MonoBehaviour 
{
	public int maxFall = -10;

	// Update is called once per frame
	void Update () 
	{
		if (transform.position.y <= maxFall) 
		{
			Application.LoadLevel("khrisRhodesPlatform");
			//print("You died!");
		}
	}
}
