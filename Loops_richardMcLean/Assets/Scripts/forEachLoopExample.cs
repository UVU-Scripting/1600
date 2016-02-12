using UnityEngine;
using System.Collections;

public class forEachLoopExample : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{

	//This is my grocery list.
		string [] groceries = new string[6];
		groceries [0] = "Electro Voice EVX-44";
		groceries [1] = "JVC 4DD-5";
		groceries [2] = "Yamaha - RX-V365";
		groceries [3] = "Sony DVPNS775V";
		groceries [4] = "Gemini XL-500 II";
		groceries [5] = "Quazar 5.1 Speaker Set";
	
	//Print My List
		Debug.Log ("This is my grocery list.");

		foreach (string value in groceries) 
		{
		
			Debug.Log (value);
		
		}

	}
	

}
