using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Novel;

public class fader : MonoBehaviour {
		public bool sflag;
		public bool gflag;
		public bool lflag;
		public bool oflag;
		public bool bflag;
	    float beta;
		float alfa;
		float galnum;
		float loanum;
		float optnum;
		float bacnum;
		float speed=0.01f;
		float red, green, blue;
		public GameObject gallerybuttons;
		public GameObject ActiveButton;

		void Start(){
			sflag = true;
			gflag = true;
			lflag = true;
			oflag = true;
			bflag = true;
			beta = 0;
			galnum = 0;
			loanum = 0;
			optnum = 0;
		    red = GetComponent<UnityEngine.UI.Image> ().color.r;
			green = GetComponent<UnityEngine.UI.Image> ().color.g;
			blue = GetComponent<UnityEngine.UI.Image> ().color.b;
		}
		void Update() {
		if (sflag) {
		} 
		else {
			GetComponent<UnityEngine.UI.Image> ().color = new Color (red, blue, green, alfa);
			alfa += speed;
			beta += Time.deltaTime;
		}
		if(beta>=1.8) {

			NovelSingleton.StatusManager.callJoker ("wide/scene1","");

		}
		//gallery
		if (gflag) {
		} 
		else {
			GetComponent<UnityEngine.UI.Image> ().color = new Color (red, blue, green, alfa);
			alfa += speed;
			galnum += Time.deltaTime;
		}
		if(galnum>=1.8) {
			gallerybuttons.gameObject.SetActive (true);
			ActiveButton.gameObject.SetActive (false);
			GetComponent<UnityEngine.UI.Image> ().color = new Color (red, blue, green, 0);
			galnum=0;
			alfa = 0;
			gflag=true;


		}
		//load
		if (lflag) {
		} 
		else {
			GetComponent<UnityEngine.UI.Image> ().color = new Color (red, blue, green, alfa);
			alfa += speed;
			loanum += Time.deltaTime;
		}
		if(loanum>=1.8) {

			NovelSingleton.StatusManager.callJoker ("wide/libs/newSave", "*loadstart");
		}

		//option
		if (oflag) {
		} 
		else {
			GetComponent<UnityEngine.UI.Image> ().color = new Color (red, blue, green, alfa);
			alfa += speed;
			optnum += Time.deltaTime;
		}
		if(optnum>=1.8) {

			Application.LoadLevel ("Player");
		}

		//gback
		if (bflag) {
		} 
		else {
			GetComponent<UnityEngine.UI.Image> ().color = new Color (red, blue, green, alfa);
			alfa += speed;
			bacnum += Time.deltaTime;
		}
		if(bacnum>=1.8) {
			gallerybuttons.gameObject.SetActive (false);
			ActiveButton.gameObject.SetActive (true);
			GetComponent<UnityEngine.UI.Image> ().color = new Color (red, blue, green, 0);
			bacnum=0;
			alfa = 0;
			bflag=true;


		}
		}
}

