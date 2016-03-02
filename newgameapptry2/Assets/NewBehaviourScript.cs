using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	public float speed = 8.0f;

	public float jumpSpeed = 7.0f;
	
	// Update is called once per frame
	void Update () 
	{
		var move = new Vector3 (Input.GetAxis("Horizontal"), Input.GetAxis ("Vertical"), 0);
		                        transform.position += move * jumpSpeed * Time.deltaTime;

		    //Jump with spacebar
		    if (Input.GetKeyDown (KeyCode.Space))
		    {
				GetComponent<Rigidbody> ().velocity += Vector3.up * jumpSpeed;
			}

	}
}
