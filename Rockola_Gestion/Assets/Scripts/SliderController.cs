using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour {

	[SerializeField]
	private Slider volumeSlider;

	[SerializeField]
	private AudioSource volumeAudio;

	public void ChangeVolume(){
		//Edita el volumen del Audiosource en base al valor del slider
		volumeAudio.volume = volumeSlider.value;
	}
		
}
