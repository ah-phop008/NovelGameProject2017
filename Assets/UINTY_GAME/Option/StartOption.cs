using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartOption : MonoBehaviour {

	GameObject option;
	private bool fadein = false;
	// Use this for initialization
	void Start () {
		option = GameObject.Find ("OptionCanvas");
	}
	
	// Update is called once per frame
	void Update () {
		if (fadein) {
			if (option.GetComponent<Fade> ().fadeCounter >= 1) {
				fadein = false;
			}
		}
	}

	public void startOption () {
		//Mainからなら、Joker側の入力処理を停止
		if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Player") {
			GameObject.Find ("InitScript").GetComponent<SceneInit> ().stopAuto ();
			GameObject.Find ("InitScript").GetComponent<SceneInit> ().stopSkip ();
			GameObject.Find ("InitScript").GetComponent<SceneInit> ().enabled = false;
		}
		fadein = true;
		option.GetComponent <Canvas> ().enabled = true;
		option.GetComponent <Fade> ().fade_in ();
	}
}
