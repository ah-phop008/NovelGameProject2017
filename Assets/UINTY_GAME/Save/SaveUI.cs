using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveUI : MonoBehaviour {

	private bool fadeout = false;
	private bool bluckout = false;
	Button[] obj;
	GameObject savecanv;


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
		

	void startFadeout () {
		savecanv = GameObject.Find ("SaveCanvas");
		obj = savecanv.GetComponentsInChildren<Button> ();
		for (int i = 0; i < obj.Length; i++) obj [i].enabled = false;
		savecanv.GetComponent <Fade> ().fade_out ();
	}

	void startBluckout () {
		savecanv = GameObject.Find ("SaveCanvas");
		obj = savecanv.GetComponentsInChildren<Button> ();
		for (int i = 0; i < obj.Length; i++) obj [i].enabled = false;
		savecanv.GetComponent <Fade> ().bluck_out ();

	}

	void Update () {
		if (fadeout) {
			if (savecanv.GetComponent <Fade> ().fadeCounter <= 0) {
				//ボタンの判定を有効(元に戻す)にして、Canvasを非表示にする
				for (int i = 0; i < obj.Length; i++)
					obj [i].enabled = true;
				fadeout = false;
				savecanv.GetComponent<Canvas> ().enabled = false;
				if (SceneManager.GetActiveScene ().name == "Player") {
					GameObject.Find ("InitScript").GetComponent<SceneInit> ().enabled = true;
				}
			}
		} else if (bluckout) {
			//タイトルへ
			if (savecanv.GetComponent <Fade> ().fadeCounter >= 1)
				SceneManager.LoadScene ("title");
		}
	}
}
