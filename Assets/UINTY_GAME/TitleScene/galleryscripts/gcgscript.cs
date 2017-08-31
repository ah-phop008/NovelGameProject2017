using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gcgscript : MonoBehaviour {
	float speed=0.05f;
	Color hontai;
	bool onGallery;
	float dispeed = -0.05f;
	public GameObject CGobjects;
	public GameObject insiders;
	public GameObject disableman;


	void Start() {
		onGallery = true;
		hontai = GetComponent<Image> ().color;
	}

	public void OnClick() {

		insiders.BroadcastMessage ("mschange");	
		insiders.BroadcastMessage ("mvchange");	
		CGobjects.gameObject.SetActive (true);
			
		
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
		}
		else {
			if (hontai.a > 0) {
				hontai.a += dispeed;
				GetComponent<Image> ().color = new Color (hontai.r, hontai.g, hontai.b, hontai.a);
			} else {
				disableman.SetActive (false);
				onGallery = true;

			}

		}
	}
}
