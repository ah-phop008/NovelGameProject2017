using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainthemeManager : MonoBehaviour {
	public AudioSource AudioSource;
	// Use this for initialization
	void stopmaintheme() {
		this.AudioSource.Stop ();
	}
	void startmaintheme() {
		this.AudioSource.Play ();
	}
}
