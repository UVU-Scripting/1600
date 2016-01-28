using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		int goombas = 12;

		while (goombas > 0) {
			Debug.Log("One Goomba has been smashed! Goomba count " + --goombas);
		}
		Debug.Log("All the Goombas are smashed...Go Mario!");
	}
}
