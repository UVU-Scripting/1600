using UnityEngine;
using System.Collections;

public class camuraControl : MonoBehaviour 
{
	public Transform target;
	public float distance = -10;
	public float lift = 1.5f;

	// Update is called once per frame
	void Update () 
	{
		transform.position = target.position + new Vector3(0, lift, distance);
	}
}
