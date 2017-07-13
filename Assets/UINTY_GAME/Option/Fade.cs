using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour {

	public float fadeSpeed;
	public float fadeCounter;
	Image[] obj;
	private bool fadein = false;
	private bool fadeout = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (fadein) {
			fadeCounter += fadeSpeed;
			for (int i = 0; i < obj.Length; i++) {
				obj [i].color = new Color (obj [i].color.r, obj [i].color.g, obj [i].color.b, fadeCounter);
			}
			if (fadeCounter >= 1) fadein = false;

		} else if (fadeout) {
			fadeCounter -= fadeSpeed;
			for (int i = 0; i < obj.Length; i++) {
				obj [i].color = new Color (obj [i].color.r, obj [i].color.g, obj [i].color.b, fadeCounter);
			}
			if (fadeCounter <= 0) fadeout = false;
		}
	}

	public void fade_in () {
		fadeCounter = 0f;
		obj = GetComponentsInChildren<Image> ();
		for (int i = 0; i < obj.Length; i++) obj [i].color = new Color (obj [i].color.r, obj [i].color.g, obj [i].color.b, 0);
		fadein = true;
	}

	public void fade_out () {
		fadeCounter = 1f;
		obj = GetComponentsInChildren<Image> ();
		for (int i = 0; i < obj.Length; i++) obj [i].color = new Color (obj [i].color.r, obj [i].color.g, obj [i].color.b, 1);
		fadeout = true;
	}

}
