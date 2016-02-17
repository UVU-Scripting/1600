using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class tallyCounterScript : MonoBehaviour 
{
	public int tallyNum;
	public Text tallyCount;
	public Button increment;
	public Button decrement;
	public Button restart;
	public AudioClip oneUp;
	public AudioClip oneDown;
	public AudioClip reset;

	private AudioSource source;

	// Use this for initialization
	void Start () 
	{
		tallyNum = 0;
		//when increment button is clicked, AddListener (The game will listen to when the button is clicked) will use Increment Function.
		increment.onClick.AddListener(() => Increment ());
		//when decrement button is clicked, AddListener will use Decrement Function.
		decrement.onClick.AddListener (() => Decrement ());
		//when restart button is clicked, AddListener will use Restart Function.
		restart.onClick.AddListener (() => Restart ());

		source = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		tallyCount.text = "Tally count = " + tallyNum;
	}

	//This function is used to increase tallyNum count.
	void Increment ()
	{
		tallyNum++;
		//audio script.
		source.PlayOneShot (oneUp);
	}

	//This function is used to decrease tallyNum count IF it is greater than 0.
	void Decrement ()
	{
		if (tallyNum > 0) 
		{
			tallyNum--;
			//audio script.
			source.PlayOneShot (oneDown);
		}
	}

	//This Function is used to reset tallyNum to 0 IF it is greater than 0.
	void Restart ()
	{
		if (tallyNum > 0) 
		{
			tallyNum = 0;
			//audio script.
			source.PlayOneShot (reset);
		}
	}
}
