using UnityEngine;
using System.Collections;

public class whileLoop : MonoBehaviour {

	int Goombas = 11;
	
	// Use this for initialization
	void Start () {
		while (Goombas >= 0 ) {
			Debug.Log ("One Goomba has been smashed!" + Goombas);
			
			Goombas --;
		}
		print("All the Goombas are smashed...Go Mario!");
	}
}