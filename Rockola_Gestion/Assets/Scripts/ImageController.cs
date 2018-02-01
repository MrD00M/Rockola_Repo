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
			alternateImage [0].enabled = false;
			alternateImage [1].enabled = false;
			alternateImage [2].enabled = false;
			alternateImage [3].enabled = false;
			alternateImage [4].enabled = false;
		}
		alternateImage[imageIndex].enabled = true;
	}
		
}
