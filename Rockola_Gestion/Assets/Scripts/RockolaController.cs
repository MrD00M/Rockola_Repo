using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class RockolaController : MonoBehaviour {

	[SerializeField]
	private AudioClip[] alternateSound;

	private int currentSoundIndex = -1;

	private AudioSource myAudioSource;

	// Use this for initialization
	void Start () {

		myAudioSource = GetComponent<AudioSource> ();
	}

	private void ChangeRight() {
		currentSoundIndex += 1;

		if (currentSoundIndex >= alternateSound.Length) {
			currentSoundIndex = 0;
		}

		if (myAudioSource != null) {
			myAudioSource.clip = alternateSound [currentSoundIndex];
			myAudioSource.Play ();
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
