using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionUI : MonoBehaviour {

	private bool fadeout = false;
	Button[] obj;
	GameObject option;
	bool title = false;

	public void totittle () {
		SystemManager.SaveOption ();
		fadeout = true;
		title = true;
		startFadeout ();
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

	void startFadeout () {
		option = GameObject.Find ("OptionCanvas");
		obj = option.GetComponentsInChildren<Button> ();
		for (int i = 0; i < obj.Length; i++) obj [i].enabled = false;
		option.GetComponent <Fade> ().fade_out ();

	}

	void Update () {
		if (fadeout) {
			if (option.GetComponent <Fade> ().fadeCounter <= 0) {
				//タイトルへ
				if (title) SceneManager.LoadScene("title");
				//ボタンの判定を有効(元に戻す)にして、Canvasを非表示にする
				for (int i = 0; i < obj.Length; i++) obj [i].enabled = true;
				fadeout = false;
				option.GetComponent<Canvas> ().enabled = false;
				if (SceneManager.GetActiveScene ().name == "Player") {
					GameObject.Find ("InitScript").GetComponent<SceneInit> ().enabled = true;
				}
			}
		}
	}
}
