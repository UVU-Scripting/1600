using UnityEngine;
using System.Collections;

public class DoWhileLoopExample : MonoBehaviour 
{
	void Start()
	{
		bool shouldContinue = false;
		
		do
		{
			print ("Hello World");
			
		}while(shouldContinue == true);
	}
}
