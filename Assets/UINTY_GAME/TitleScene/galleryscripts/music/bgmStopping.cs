using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmStopping : MonoBehaviour {
	public AudioSource AudioSource;
	public GameObject musicObjects;
	bool yesno;

	void Start() {
		yesno = false;
	}


	public void OnClick() {
		yesno = true;
		this.AudioSource.Play ();
		musicObjects.BroadcastMessage ("stopbgm");

	}

	void stopbgm() {
		if (yesno) {
			yesno = false;
		}
		else{
			this.AudioSource.Stop ();
		}
	}
}
