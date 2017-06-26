using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	public static SoundManager Instance = null;

	public AudioClip hit;

	private AudioSource audioEffects;

	// Use this for initialization
	void Start () {
		if (Instance == null) {
			Instance = this;
		} else if (Instance != this) {
			Destroy (gameObject);
		}

		AudioSource[] sources = GetComponents<AudioSource> ();

		foreach (AudioSource source in sources) {
			if (source.clip == null) {
				audioEffects = source;
			}
		}
	}

	public void PlayOneShot (AudioClip audio) {
		audioEffects.PlayOneShot (audio);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
