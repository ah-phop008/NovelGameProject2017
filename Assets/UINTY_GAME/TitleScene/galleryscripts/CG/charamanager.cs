using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class charamanager : MonoBehaviour {
	
	public GameObject cgp6;
	public GameObject CGobjects;
	public GameObject frame;
	GameObject parent;
	float speed=0.05f;
	float dispeed=-0.05f;
	bool onGallery;
	Color hontai;

	void Start() {
		onGallery = true;
		hontai.r = GetComponent<Image> ().color.r;
		hontai.g = GetComponent<Image> ().color.g;
		hontai.b = GetComponent<Image> ().color.b;
	}

	void byeGallery() {
		onGallery = false;
	}

	void helloGallery() {
		onGallery = true;
	}

	void cgchange() {
		//onGallery = false;
		//changetime = true;
		hontai.a=0;
		GetComponent<Image> ().color = new Color (hontai.r, hontai.g, hontai.b, hontai.a);
		//CGobjects.gameObject.SetActive (false);
	}

	public void OnClick() {
		CGobjects.BroadcastMessage ("cyaframe");
		CGobjects.BroadcastMessage ("zero");
		cgp6.gameObject.SetActive (true);
		parent = transform.parent.gameObject;
		for(int i=0; i< parent.transform.childCount; i++)
		{
			GameObject child = parent.transform.GetChild(i).gameObject;
			if (child != null) {
				//child.setActive(false);
				child.GetComponent<Button> ().enabled=true;
				Debug.Log (i);
			}
			GetComponent<Button> ().enabled = false;
			frame.SetActive (true);

	}
	}
		
	void Update() {
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
