using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cgb1script : MonoBehaviour {
	public GameObject cgf1;
	public GameObject CGobjects;
	float speed = 0.1f;
	float dispeed = -0.1f;
	bool switcher;
	Color hontai;
	// Use this for initialization

	void Start() {
		hontai.a = 0;
		switcher = false;
		hontai.r = GetComponent<Image> ().color.r;
		hontai.g = GetComponent<Image> ().color.g;
		hontai.b = GetComponent<Image> ().color.b;
	}

	void zero() {
		if (switcher = true) {
			
				hontai.a=0;
				GetComponent<Image> ().color = new Color (hontai.r, hontai.g, hontai.b, hontai.a);
			switcher = false;

		}

	}


	public void OnClick() {
		cgf1.gameObject.SetActive (true);
	}

	void Update() {
			if (hontai.a< 1.28) {

				GetComponent<Image> ().color = new Color (hontai.r,hontai.g,hontai.b,hontai.a);
				hontai.a += speed;
			switcher = true;
			Debug.Log ("aaa");
		} 


		//beta += Time.deltaTime;
	}



}
