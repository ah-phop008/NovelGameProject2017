using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class framemanager : MonoBehaviour {
	Color hontaix;
	float speed=0.05f;
	// Use this for initialization
	void Start () {
		hontaix.r = GetComponent<Image> ().color.r;
		hontaix.g = GetComponent<Image> ().color.g;
		hontaix.b = GetComponent<Image> ().color.b;
		hontaix.a = GetComponent<Image> ().color.a;
		
	}

	void cyaframe() {
		GetComponent<Image> ().gameObject.SetActive (false);
	}

	void cgchange() {
		//onGallery = false;
		//changetime = true;
		hontaix.a=0;
		GetComponent<Image> ().color = new Color (hontaix.r, hontaix.g, hontaix.b, hontaix.a);
		//CGobjects.gameObject.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
			if (hontaix.a < 1.28) {

				GetComponent<Image> ().color = new Color (hontaix.r, hontaix.g, hontaix.b, hontaix.a);
				hontaix.a += speed;
			}
		
	}
}
