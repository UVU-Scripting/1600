using UnityEngine;
using System.Collections;

public class derpyControl : MonoBehaviour 
{
	public Rigidbody rb;
	public float jumpHeight = 5;
	public float walking = 5;
	
	private int turnAround = 180;
	private int jumpCount = 2;
	private bool inAir = false;
	private bool facingForward = true;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		// while D is held down, player will move to the right.
		if (Input.GetKey (KeyCode.D)) 
		{
			transform.Translate(walking * Time.deltaTime, 0, 0);
			if (facingForward == false)
			{
				transform.Rotate(0, turnAround, 0);
				facingForward = true;
			}
		}

		// while A is held down, player will move to the left.
		if (Input.GetKey (KeyCode.A))
		{
			transform.Translate(walking * Time.deltaTime, 0, 0);
			if (facingForward == true)
			{
				transform.Rotate(0, turnAround, 0);
				facingForward = false;
			}
		}

		// if spacebar is down and inAir bool = false, player will jump and lose a jump count.
		if (Input.GetKeyDown (KeyCode.Space) && inAir == false) 
		{
			rb.velocity = new Vector3(0, jumpHeight, 0);
			jumpCount--;
		}
		// if jump count = zero, inair bool = true.
		if (jumpCount == 0) 
		{
			inAir = true;
		}
	}
	// if player collides with object with "floor" tag, inAir = false and jump count reset to two.
	void OnCollisionEnter (Collision other)
	{
		if (other.collider.tag == "floor") 
		{
			inAir = false;
			jumpCount = 2;
		}
	}
}
