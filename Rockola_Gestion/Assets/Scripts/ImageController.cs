using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageController : MonoBehaviour {

	//Se toma la referencia de las imagenes y se define el index
	[SerializeField]
	private RawImage[] alternateImage;

	public int imageIndex = -1;

	void Start () {
	}

	public void ChangeRight() {
		//Se cambia la imagen a la derecha
		imageIndex += 1;

		if (imageIndex >= 5) {
			imageIndex = 0;
			/*alternateImage [0].enabled = false;
			alternateImage [1].enabled = false;
			alternateImage [2].enabled = false;
			alternateImage [3].enabled = false;
			alternateImage [4].enabled = false;*/
		}
		//alternateImage[imageIndex].enabled = true;

		switch (imageIndex)
		{
		case 0:
			alternateImage[0].enabled = true;
			alternateImage[1].enabled = false;
			alternateImage[2].enabled = false;
			alternateImage[3].enabled = false;
			alternateImage[4].enabled = false;
			break;
		case 1:
			alternateImage[1].enabled = true;
			//alternateImage[2].enabled = false;
			break;
		case 2:
			alternateImage[2].enabled = true;
			//alternateImage[3].enabled = false;
			break;
		case 3:
			alternateImage[3].enabled = true;
			//alternateImage[4].enabled = false;
			break;
		case 4:
			alternateImage[4].enabled = true;
			//alternateImage[0].enabled = false;
			break;
		}
	}

	public void ChangeLeft() {
		//Se cambia la imagen a la derecha
		imageIndex -= 1;

		if (imageIndex <= -1) {
			imageIndex = 4;
		}
		//alternateImage[imageIndex].enabled = true;

		switch (imageIndex)
		{
		case 0:
			alternateImage[0].enabled = true;
			alternateImage[1].enabled = false;
			break;
		case 1:
			alternateImage[1].enabled = true;
			alternateImage[2].enabled = false;
			break;
		case 2:
			alternateImage[2].enabled = true;
			alternateImage[3].enabled = false;
			break;
		case 3:
			alternateImage[3].enabled = true;
			alternateImage[4].enabled = false;
			break;
		case 4:
			alternateImage[4].enabled = true;
			//alternateImage[0].enabled = false;
			alternateImage[1].enabled = false;
			alternateImage[2].enabled = false;
			alternateImage[3].enabled = false;
			alternateImage[0].enabled = false;
			break;
		}

	}
		
}
