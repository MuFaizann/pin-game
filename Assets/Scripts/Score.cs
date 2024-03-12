using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public static int PinCount;
	public static int HighestPinCount;

	public Text text;


	void Start ()
	{
		PinCount = 0;
		HighestPinCount = PlayerPrefs.GetInt("highestPinCount", 0);
	}

	void Update ()
	{
		text.text = PinCount.ToString();

		if (PinCount > HighestPinCount) {
		HighestPinCount = PinCount;
		PlayerPrefs.SetInt("highestPinCount", HighestPinCount);
	}
	}

}
