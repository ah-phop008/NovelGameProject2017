using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionUI : MonoBehaviour {

	private bool fadeout = false;
	private bool bluckout = false;
	Button[] obj;
	GameObject option;

	public GameObject config;
	public GameObject shortcut;


	public void totittle () {
		SystemManager.SaveOption ();
		bluckout = true;
		startBluckout ();
	}


	public void back () {
		SystemManager.SaveOption ();
		if (SceneManager.GetActiveScene ().name == "Player") {
			GameObject init = GameObject.Find ("InitScript");
			init.GetComponent<SceneInit> ().messageSpeed = SystemManager.messageSpeed;
		}
		fadeout = true;
		startFadeout ();
	}


	public void showConfig () {
		shortcut.SetActive (false);
		config.SetActive (true);
	}

	public void showShortCut () {
		config.SetActive (false);
		shortcut.SetActive (true);
	}

	void startFadeout () {
		option = GameObject.Find ("OptionCanvas");
		obj = option.GetComponentsInChildren<Button> ();
		for (int i = 0; i < obj.Length; i++) obj [i].enabled = false;
		option.GetComponent <Fade> ().fade_out ();
	}

	void startBluckout () {
		option = GameObject.Find ("OptionCanvas");
		obj = option.GetComponentsInChildren<Button> ();
		for (int i = 0; i < obj.Length; i++) obj [i].enabled = false;
		option.GetComponent <Fade> ().bluck_out ();

	}

	void Update () {
		if (fadeout) {
			if (option.GetComponent <Fade> ().fadeCounter <= 0) {
				//ボタンの判定を有効(元に戻す)にして、Canvasを非表示にする
				for (int i = 0; i < obj.Length; i++)
					obj [i].enabled = true;
				fadeout = false;
				option.GetComponent<Canvas> ().enabled = false;
				if (SceneManager.GetActiveScene ().name == "Player") {
					GameObject.Find ("InitScript").GetComponent<SceneInit> ().enabled = true;
				}
			}
		} else if (bluckout) {
			//タイトルへ
			if (option.GetComponent <Fade> ().fadeCounter >= 1)
				SceneManager.LoadScene ("title");
		}
	}
}
