using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cgb1script : MonoBehaviour {
	public GameObject cgf1;
	public GameObject CGobjects;
	float speed = 0.05f;
	float dispeed = -0.05f;
	Color hontai;
	bool onGallery;
	bool helloCGb;
	// Use this for initialization

	void Start() {
		onGallery = true;
		helloCGb = true;
		hontai = GetComponent<Image> ().color;
		hontai.a = 0;

	
	}

	void zero() {

			
		helloCGb = false;


	}


	public void OnClick() {
		cgf1.gameObject.SetActive (true);
	}

	void byeGallery() {
		onGallery = false;
	}

	void helloGallery() {
		onGallery = true;
	}

	void cgchange() {
		//onGallery = false;
		hontai.a=0;
		GetComponent<Image> ().color = new Color (hontai.r, hontai.g, hontai.b, hontai.a);
	}

	void Update() {
		if (onGallery) {
			if (helloCGb) {
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
					helloCGb = true;
				}


				//beta += Time.deltaTime;
			}
		} else {
			if (hontai.a > 0) {
				hontai.a += dispeed;
				GetComponent<Image> ().color = new Color (hontai.r, hontai.g, hontai.b, hontai.a);
			} else {
				onGallery = true;

			}
		}



	}
	}
