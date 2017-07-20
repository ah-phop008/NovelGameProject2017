using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cgb9script : MonoBehaviour {
	public GameObject cgf1;
	public GameObject CGobjects;
	public GameObject cgpX;
	public GameObject disableman;
	float speed = 0.05f;
	float dispeed = -0.05f;
	float pts=0f;
	bool onGallery;
	bool helloCGb;
	Color hontai;
	// Use this for initialization

	void Start() {
		hontai.a = 0;
		onGallery = true;
		helloCGb = true;

		hontai = GetComponent<Image> ().color;
	}

	void zero() {

		disableman.gameObject.SetActive (true);
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
		hontai.a=0;
		GetComponent<Image> ().color = new Color (hontai.r, hontai.g, hontai.b, hontai.a);
		CGobjects.gameObject.SetActive (false);
	}

	void Update() {
		if (onGallery) {
			if (helloCGb) {
			
				if (hontai.a < 1.28) {

					GetComponent<Image> ().color = new Color (hontai.r, hontai.g, hontai.b, hontai.a);
					hontai.a += speed;
					pts = 0;
					Debug.Log ("aaa");
				} else {
					if (pts < 5) {
						pts += 1;
					} else {
						disableman.gameObject.SetActive (false);

					}
				}
			
			} else {
				if (hontai.a > 0) {
					hontai.a += dispeed;
					GetComponent<Image> ().color = new Color (hontai.r, hontai.g, hontai.b, hontai.a);

				} else {
					helloCGb = true;
					cgpX.gameObject.SetActive (false);
				}
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
