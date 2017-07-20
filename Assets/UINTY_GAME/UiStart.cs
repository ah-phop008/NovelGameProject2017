using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiStart : MonoBehaviour {

	GameObject option;
	GameObject savecanv;
	private bool fadeinOption = false;
	private bool fadeinSaveLoad = false;
	// Use this for initialization
	void Start () {
		option = GameObject.Find ("OptionCanvas");
		savecanv= GameObject.Find ("SaveCanvas");
	}

	// Update is called once per frame
	void Update () {
		if (fadeinOption) {
			if (option.GetComponent<Fade> ().fadeCounter >= 1) {
				fadeinOption = false;
			}
		} else if (fadeinSaveLoad) {
			if (savecanv.GetComponent<Fade> ().fadeCounter >= 1) {
				fadeinSaveLoad = false;

				if (!savecanv.GetComponent <SaveScreen> ().LoadMode) {
					//startSave()で無効化したコンポーネントを有効化、透過率を0に設定
					Image img;
					for (int i = 0; i < 6; i++) {
						img = savecanv.transform.Find ("SaveLoad").Find ("button" + (i + 1)).Find ("limg").gameObject.GetComponent <Image> ();
						img.color = new Color (img.color.r, img.color.g, img.color.b, 0);
						img.enabled = true;
					}
					img = savecanv.transform.Find ("switchLS").Find ("toSave").gameObject.GetComponent <Image> ();
					img.color = new Color (img.color.r, img.color.g, img.color.b, 0);
					img.enabled = true;
					img = savecanv.transform.Find ("Load_background").gameObject.GetComponent <Image> ();
					img.color = new Color (img.color.r, img.color.g, img.color.b, 0);
					img.enabled = true;
				}
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
		fadeinOption = true;
		option.GetComponent <Canvas> ().enabled = true;
		option.GetComponent <Fade> ().fade_in ();
	}

	public void startLoad () {
		//Mainからなら、Joker側の入力処理を停止
		if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Player") {
			GameObject.Find ("InitScript").GetComponent<SceneInit> ().stopAuto ();
			GameObject.Find ("InitScript").GetComponent<SceneInit> ().stopSkip ();
			GameObject.Find ("InitScript").GetComponent<SceneInit> ().enabled = false;
		}
		fadeinSaveLoad = true;
		savecanv.GetComponent <Canvas> ().enabled = true;
		savecanv.GetComponent <Fade> ().fade_in ();
		savecanv.GetComponent <SaveScreen> ().LoadMode = true;
		//ボタンのTargetGrapicを変更
		savecanv.GetComponent<SaveScreen> ().ChangeButtonImg ();

		//ロードに使うUIを表示, 91行目の処理に対する処置
		for (int i = 0; i < 6; i++) {
			savecanv.transform.Find ("SaveLoad").Find ("button" + (i + 1)).Find ("limg").gameObject.GetComponent <Image> ().enabled = true;
		}
		savecanv.transform.Find("switchLS").Find("toSave").gameObject.GetComponent <Image> ().enabled = true;
		savecanv.transform.Find("Load_background").gameObject.GetComponent <Image> ().enabled = true;
	}

	public void startSave () {
		//Mainからなら、Joker側の入力処理を停止
		if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name == "Player") {
			GameObject.Find ("InitScript").GetComponent<SceneInit> ().stopAuto ();
			GameObject.Find ("InitScript").GetComponent<SceneInit> ().stopSkip ();
			GameObject.Find ("InitScript").GetComponent<SceneInit> ().enabled = false;
		}
		fadeinSaveLoad = true;
		savecanv.GetComponent <Canvas> ().enabled = true;
		savecanv.GetComponent <Fade> ().fade_in ();
		savecanv.GetComponent <SaveScreen> ().LoadMode = false;
		//ボタンのTargetGrapicを変更
		savecanv.GetComponent<SaveScreen> ().ChangeButtonImg ();

		//セーブに使うUIの上にあるものが、Fade.csの処理で非透明になるのを防ぐ
		for (int i = 0; i < 6; i++) {
			savecanv.transform.Find ("SaveLoad").Find ("button" + (i + 1)).Find ("limg").gameObject.GetComponent <Image> ().enabled = false;
		}
		savecanv.transform.Find("switchLS").Find("toSave").gameObject.GetComponent <Image> ().enabled = false;
		savecanv.transform.Find("Load_background").gameObject.GetComponent <Image> ().enabled = false;
	}
}
