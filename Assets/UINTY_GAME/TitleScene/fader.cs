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
	    float beta;
		float alfa;
		float galnum;
		float loanum;
		float optnum;
		float speed=0.01f;
		float red, green, blue;

		void Start(){
			sflag = true;
			gflag = true;
			lflag = true;
			oflag = true;
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

			Application.LoadLevel ("Player");

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

			NovelSingleton.StatusManager.callJoker ("wide/libs/save", "*loadstart");
		}

		//load
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
		}
}

