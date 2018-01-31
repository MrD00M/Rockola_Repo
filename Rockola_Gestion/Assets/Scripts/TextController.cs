﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	[SerializeField]
	private Text alternateText;

	public int textIndex = -1;

	// Use this for initialization
	void Start () {

	}

	public void ChangeRight() {
		textIndex += 1;

		if (textIndex >= 5){
			textIndex = 0;
		}
		switch (textIndex)
		{
		case 0:
			alternateText.text = "Brazil anthem";
			Debug.Log ("si funciono");
			break;
		case 1:
			alternateText.text = "Israel anthem";
			break;
		case 2:
			alternateText.text = "Peru anthem";
			break;
		case 3:
			alternateText.text = "Turkey anthem";
			break;
		case 4:
			alternateText.text = "USSR anthem";
			break;
		}
	}

	public void ChangeLeft() {
		textIndex -= 1;

		if (textIndex <= -1){
			textIndex = 5;
		}
		switch (textIndex)
		{
		case 0:
			alternateText.text = "Brazil anthem";
			Debug.Log ("si funciono");
			break;
		case 1:
			alternateText.text = "Israel anthem";
			break;
		case 2:
			alternateText.text = "Peru anthem";
			break;
		case 3:
			alternateText.text = "Turkey anthem";
			break;
		case 4:
			alternateText.text = "USSR anthem";
			break;
		}
	}


	// Update is called once per frame
	void Update () {
		
	}
}
