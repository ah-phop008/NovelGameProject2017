using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cgf1manager : MonoBehaviour {
	GameObject parent;
	public float showing;
	float speed = 0.1f;
	float red, green, blue;
	// Use this for initialization

	void Start() {
		showing = 0;
		red = GetComponent<Image> ().color.r;
		green = GetComponent<Image> ().color.g;
		blue = GetComponent<Image> ().color.b;
	}

	public void OnClick() {
		showing = 0;
		GetComponent<Image> ().color = new Color (red, blue, green, showing);
		parent = transform.parent.gameObject;
		for(int i=0; i< parent.transform.childCount; i++)
		{
			GameObject child = parent.transform.GetChild(i).gameObject;
			if (child != null) {
				//child.setActive(false);
				child.GetComponent<Button> ().gameObject.SetActive(false);
				Debug.Log (i);
			}
		}
	}

	void Update() {
		if (showing < 3) {

			GetComponent<Image> ().color = new Color (red, blue, green, showing);
			showing += speed;
		}
		//beta += Time.deltaTime;
	}
}
