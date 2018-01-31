using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class RockolaController : MonoBehaviour {

	[SerializeField]
	private AudioClip[] alternateSound;



	private AudioSource myAudioSource;

	// Use this for initialization
	void Start () {

		myAudioSource = GetComponent<AudioSource> ();
	}
		
	
	// Update is called once per frame
	void Update () {
		
	}
}
