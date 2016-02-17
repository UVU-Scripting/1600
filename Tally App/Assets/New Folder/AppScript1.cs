using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AppScript1 : MonoBehaviour {

	public Text text;
	public int tallyInt;
	public Button button1;
	public Button button2;
	public Button button3;

	// Use this for initialization
	public void start () 
	{
		tallyInt = 0;
		SetTallyText ();
		button1 = button1.GetComponent<Button> ();
		button2 = button2.GetComponent<Button> ();
		button3 = button3.GetComponent<Button> ();
		text = text.GetComponent<Text> ();
	}

	// Update is called once per frame
	public void Increase () 
	
		{
			tallyInt ++;
			SetTallyText ();
		}
	
	public void Decrease ()
	{
		if (tallyInt > 0) {
			tallyInt --;
			SetTallyText ();
		}
	}
	public void Reset ()
	
	 {
			tallyInt = 0;
			SetTallyText ();
		}
	


	public void SetTallyText ()
	{
		text.text = "Tally: " + tallyInt.ToString ();
	}
}
