﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gallerybg : MonoBehaviour {
	float speed=0.05f;
	Color hontai;
	bool onGallery;
	float dispeed = -0.05f;
	// Use this for initialization
	void Start () {
		onGallery = true;
		hontai = GetComponent<Image> ().color;
		
	}
	void byeGallery() {
		onGallery = false;
	}

	void helloGallery() {
		onGallery = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (onGallery) {
			if (hontai.a < 1.28) {
				GetComponent<Image> ().color = new Color (hontai.r, hontai.g, hontai.b, hontai.a);
				hontai.a += speed;
			}
		}
		else {
			if (hontai.a > 0) {
				hontai.a += dispeed;
				GetComponent<Image> ().color = new Color (hontai.r, hontai.g, hontai.b, hontai.a);
			} else {
				onGallery = true;
			
			}

		}
		
	}
}
