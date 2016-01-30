using UnityEngine;
using System.Collections;

public class whileLoopExample : MonoBehaviour
{
int goombasBeingSmashed = 11;

// Use this for initialization
void Start ()
{
	while (goombasBeingSmashed >= 0)
	{
		Debug.Log("One Goomba has been smashed! Goomba count: " + goombasBeingSmashed);

		goombasBeingSmashed --;

	}
	bool atEnd= false;

	do
	{
		print ("All the Goombas are smashed...Go Mario!");
	} while (atEnd == true);

}
}
