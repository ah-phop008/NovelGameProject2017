using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bgmcovermanager : MonoBehaviour {


	public GameObject musicObjects;
	public GameObject CGobjects;
	float speed=0.05f;
	float dispeed=-0.05f;
	bool onGallery;
	Color hontai;
	bool yesno;

	// Use this for initialization
	void Start () {
		onGallery = true;
		yesno = false;
		hontai.r = GetComponent<Image> ().color.r;
		hontai.g = GetComponent<Image> ().color.g;
		hontai.b = GetComponent<Image> ().color.b;
		
	}

	void deletecover() {
		hontai.a=0;
		GetComponent<Image> ().color = new Color (hontai.r, hontai.g, hontai.b, hontai.a);

		GetComponent<Image> ().gameObject.SetActive (false);
	}

	void byeGallery() {
		hontai.a=0;
		GetComponent<Image> ().color = new Color (hontai.r, hontai.g, hontai.b, hontai.a);
		GetComponent<Image>().gameObject.SetActive (false);
	}



	void mschange() {
		//onGallery = false;
		//changetime = true;
		hontai.a=0;
		GetComponent<Image> ().color = new Color (hontai.r, hontai.g, hontai.b, hontai.a);
		//musicObjects.gameObject.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
		if (onGallery) {
			if (hontai.a < 1.28) {
				Debug.Log ("ononon");
				GetComponent<Image> ().color = new Color (hontai.r, hontai.g, hontai.b, hontai.a);
				hontai.a += speed;
			}
		}else {
			if (hontai.a > 0) {
				Debug.Log ("ofofof");
				hontai.a += dispeed;
				GetComponent<Image> ().color = new Color (hontai.r, hontai.g, hontai.b, hontai.a);
			} else {
				onGallery = true;


			}
		}
		
	}
}
