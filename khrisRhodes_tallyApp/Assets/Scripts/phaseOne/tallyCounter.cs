using UnityEngine;
using System.Collections;

public class tallyCounter : MonoBehaviour 
{
	int tally = 0;

	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.A)) 
		{
			tally++;
			print (tally);
		}

		if (Input.GetKeyDown (KeyCode.S)) 
		{
			if (tally > 0)
			{
				tally--;
				print (tally);
			}

			else
			{
				print (tally);
			}
		}

		if (Input.GetKeyDown (KeyCode.R)) 
		{
			tally = 0;
			print (tally);
		}
	}
}
