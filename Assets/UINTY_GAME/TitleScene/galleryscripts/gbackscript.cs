using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gbackscript : MonoBehaviour {
	float speed=0.05f;
	float dispeed = -0.05f;
	Color hontai;
	bool onGallery;
	public GameObject maincamera;
	public GameObject Panel;
	public GameObject disableman;
	public GameObject galleryUI;

	GameObject ButtonParent;

	// Use this for initialization
	void Start() {
		onGallery = true;
		hontai = GetComponent<Image> ().color;
		ButtonParent = GameObject.Find ("CGobjects");
	}

	// Update is called once per frame

	public void OnClick() {
		disableman.SetActive (true);
		Debug.Log ("button click!");
		maincamera.SendMessage ("startmaintheme");
		galleryUI.BroadcastMessage ("byeGallery");
		ButtonParent.GetComponent<unableee> ().ButtonOff();
	}

	void byeGallery() {
		onGallery = false;
	}

	void helloGallery() {
		onGallery = true;
	}

	void Update() {
		if (onGallery) {
			if (hontai.a < 1.28) {

				GetComponent<Image> ().color = new Color (hontai.r, hontai.g, hontai.b, hontai.a);
				hontai.a += speed;
				Debug.Log ("aaa");
			}
		} else {
			if (hontai.a > 0) {
				hontai.a += dispeed;
				GetComponent<Image> ().color = new Color (hontai.r, hontai.g, hontai.b, hontai.a);
			} else {
				onGallery = true;
				galleryUI.gameObject.SetActive (false);
			}

	}
}
}
