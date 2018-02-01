using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	//Se toma la referencia del Text y se define el index

	[SerializeField]
	private Text alternateText;

	public int textIndex = -1;


	public void ChangeRight() {
		//Se cambia el titulo a la cancion de la derecha tocando
		textIndex += 1;

		if (textIndex >= 5){
			textIndex = 0;
		}
		switch (textIndex)
		{
		case 0:
			alternateText.text = "Brazil anthem";
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
		//Se cambia el titulo a la cancion de la izquierda tocando
		textIndex -= 1;

		if (textIndex <= -1){
			textIndex = 4;
		}
		switch (textIndex)
		{
		case 0:
			alternateText.text = "Brazil anthem";
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
}
