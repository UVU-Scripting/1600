using UnityEngine;
using System.Collections;

public class forEachLoopExample : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		string[] strings = new string[4];
		//array of 4 items
		strings[0] = "chocolate donut";
		strings[1] = "maple bacon donut";
		strings[2] = "glazed donut";
		strings[3] = "creme-filled donut";

		foreach (string item in strings) 
		{
			print (item);
		}
	}


}
