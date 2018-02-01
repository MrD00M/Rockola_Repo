using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class RockolaController : MonoBehaviour {

	//Se toma la referencia del Audiosource y se define el index
	[SerializeField]
	private AudioClip[] alternateSound;

	private int currentSoundIndex = -1;

	private AudioSource myAudioSource;

	void Start () {

		myAudioSource = GetComponent<AudioSource> ();
	}

	public void ChangeRight() {
		//Se cambia la cancion a la derecha
		currentSoundIndex += 1;

		if (currentSoundIndex >= alternateSound.Length) {
			currentSoundIndex = 0;
		}

		if (myAudioSource != null) {
			myAudioSource.clip = alternateSound [currentSoundIndex];
			myAudioSource.Play ();
		}
	}

	public void ChangeLeft() {
		//Se cambia la cancion a la izquierda
		currentSoundIndex -= 1;
		if (currentSoundIndex <= -1) {
			currentSoundIndex = 4;
		}

		if (myAudioSource != null) {
			myAudioSource.clip = alternateSound [currentSoundIndex];
			myAudioSource.Play ();
		}
	}
		
}
