using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveUI : MonoBehaviour {


	private bool fadeout = false;
	private bool bluckout = false;
	private bool changeSLmode = false;

	Button[] bobj;
	GameObject savecanv;

	Image ChangeButton;
	Image[] LoadImg = new Image[6];
	float changeCounter = 0;


	public void totittle () {
		bluckout = true;
		startBluckout ();
	}


	public void back () {
		fadeout = true;
		startFadeout ();
	}

	public void right () {
		GameObject obj = GameObject.Find ("SaveCanvas");
		obj.GetComponent<SaveScreen> ().pageNum++;
		obj.GetComponent<SaveScreen> ().UpdateSavedata ();
	}
	public void left () {
		GameObject obj = GameObject.Find ("SaveCanvas");
		obj.GetComponent<SaveScreen> ().pageNum--;
		obj.GetComponent<SaveScreen> ().UpdateSavedata ();
	}

	public void SwitchSL () {
		savecanv = GameObject.Find ("SaveCanvas");
		//ボタン無効化
		bobj = savecanv.GetComponentsInChildren<Button> ();
		for (int i = 0; i < bobj.Length; i++) bobj [i].enabled = false;
		if (savecanv.GetComponent<SaveScreen> ().LoadMode) {
			//セーブ画面へ
			savecanv.GetComponent<SaveScreen> ().LoadMode = false;
			string path;
			for (int i = 0; i < 6; i++) {
				//path = "SaveLoad/button_" + 
				LoadImg[i] = savecanv.transform.Find ("SaveLoad").Find ("button" + (i + 1)).Find ("limg").gameObject.GetComponent <Image> ();
				LoadImg[i].color = new Color (LoadImg[i].color.r, LoadImg[i].color.g, LoadImg[i].color.b, 1);
			}
			changeCounter = 1;

		} else {
			//ロード画面へ
			savecanv.GetComponent<SaveScreen> ().LoadMode = true;
			for (int i = 0; i < 6; i++) {
				LoadImg[i] = savecanv.transform.Find ("SaveLoad").Find ("button" + (i + 1)).Find ("limg").gameObject.GetComponent <Image> ();
				LoadImg[i].color = new Color (LoadImg[i].color.r, LoadImg[i].color.g, LoadImg[i].color.b, 0);
			}
			changeCounter = 0;
		}
		changeSLmode = true;
	}

	public void StartSaveLoad () {

	}
		

	void startFadeout () {
		savecanv = GameObject.Find ("SaveCanvas");
		bobj = savecanv.GetComponentsInChildren<Button> ();
		for (int i = 0; i < bobj.Length; i++) bobj [i].enabled = false;
		savecanv.GetComponent <Fade> ().fade_out ();
	}

	void startBluckout () {
		savecanv = GameObject.Find ("SaveCanvas");
		bobj = savecanv.GetComponentsInChildren<Button> ();
		for (int i = 0; i < bobj.Length; i++) bobj [i].enabled = false;
		savecanv.GetComponent <Fade> ().bluck_out ();

	}

	void startChangeSLmode () {
		savecanv = GameObject.Find ("SaveCanvas");
		bobj = savecanv.GetComponentsInChildren<Button> ();
		for (int i = 0; i < bobj.Length; i++) bobj [i].enabled = false;


	}

	void ChangingSL () {
		if (savecanv.GetComponent<SaveScreen> ().LoadMode) {
			changeCounter += 0.1f;
			for (int i = 0; i < LoadImg.Length; i++) {
				LoadImg [i].color = new Color (LoadImg[i].color.r, LoadImg[i].color.g, LoadImg[i].color.b, changeCounter);
			}
			if (changeCounter >= 1) {
				//切り替え終了
				for (int i = 0; i < bobj.Length; i++) bobj [i].enabled = true;
				changeSLmode = false;
			}

		} else {
			changeCounter -= 0.1f;
			for (int i = 0; i < LoadImg.Length; i++) {
				LoadImg [i].color = new Color (LoadImg[i].color.r, LoadImg[i].color.g, LoadImg[i].color.b, changeCounter);
			}
			if (changeCounter <= 0) {
				//切り替え終了
				for (int i = 0; i < bobj.Length; i++) bobj [i].enabled = true;
				changeSLmode = false;
			}
		}

	}

	void Update () {
		if (fadeout) {
			if (savecanv.GetComponent <Fade> ().fadeCounter <= 0) {
				//ボタンの判定を有効(元に戻す)にして、Canvasを非表示にする
				for (int i = 0; i < bobj.Length; i++)
					bobj [i].enabled = true;
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
		} else if (changeSLmode) {
			
			ChangingSL ();

		}
	}
}
