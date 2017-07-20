using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Novel;

public class SaveScreen : MonoBehaviour {
	public int pageNum = 0;
	int savedataNum;
	public bool LoadMode = true;
	bool Loading = false;

	Button[] button = new Button[7];
	UnityEngine.UI.Image[] simg = new UnityEngine.UI.Image[7];
	UnityEngine.UI.Image[] limg = new UnityEngine.UI.Image[7];

	SaveData[] data = new SaveData[6];

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 6; i++) { 
			data [i] = new SaveData ();
			data[i].GetSavedataText (transform.Find ("data/data" + (i + 1)).gameObject);

			button [i] = transform.Find ("SaveLoad").Find ("button" + (i + 1)).gameObject.GetComponent<Button> ();
			simg[i] = transform.Find ("SaveLoad").Find ("button" + (i + 1)).Find("simg").gameObject.GetComponent<UnityEngine.UI.Image> ();
			limg[i] = transform.Find ("SaveLoad").Find ("button" + (i + 1)).Find("limg").gameObject.GetComponent<UnityEngine.UI.Image> ();
		}
		putSavedata (pageNum);

		button [6] = transform.Find ("switchLS").gameObject.GetComponent<Button> ();
		simg[6] = transform.Find ("switchLS").Find("toLoad").gameObject.GetComponent<UnityEngine.UI.Image> ();
		limg[6] = transform.Find ("switchLS").Find("toSave").gameObject.GetComponent<UnityEngine.UI.Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Loading) {
			if (GetComponent <Fade> ().fadeCounter >= 1) UnityEngine.SceneManagement.SceneManager.LoadScene ("Player");
		}
	}

	//セーブデータの情報を取得
	//save_0はオートセーブ用
	void putSavedata (int num) {
		string name;
		SaveObject obj;
		for (int i = 0; i < 6; i++) {
			name = "save_" + (num * 6 + i + 1);
			obj = NovelSingleton.SaveManager.getSaveData (name);
			data [i].num.text = "" + (num * 6 + i + 1);

			if (obj == null) {
				data [i].chapter.text = "";
				data [i].date.text = "";
				data [i].detail.text = "データがありません";
			} else {
				data [i].chapter.text = obj.chapter;
				data [i].date.text = "" + obj.date;
				data [i].detail.text = obj.currentMessage;
			}
		}
	}

	//ページ切り替え時にデータを更新
	public void UpdateSavedata () {
		/*if (pageNum > 2) {
			pageNum = 0;
		} else if (pageNum < 0) {
			pageNum = 2;
		}*/
		putSavedata (pageNum);
	}


	public void ChangeButtonImg () {
		if (LoadMode) {
			for (int i = 0; i < 7; i++) {
				button [i].image = limg [i];
			}
		} else {
			for (int i = 0; i < 7; i++) {
				button [i].image = simg [i];
			}
		}
	}


	public void SaveLoadData (int num) {
		string path = "save_" + num;
		if (LoadMode) {
			StatusManager.nextLoad = path;
			Debug.Log ("Load :　" + path);
		
			GetComponent<Fade> ().bluck_out ();
			Loading = true;
		} else {
			NovelSingleton.SaveManager.save (path);
			UpdateSavedata ();
			Debug.Log ("Save :　" + path);
		}
	}

	class SaveData {
		public Text num;
		public Text chapter;
		public Text date;
		public Text detail;

		public void GetSavedataText (GameObject obj) {
			this.num = obj.transform.Find ("Num").gameObject.GetComponent<Text> ();
			this.chapter = obj.transform.Find ("Chapter").gameObject.GetComponent<Text> ();
			this.date = obj.transform.Find ("date").gameObject.GetComponent<Text> ();
			this.detail = obj.transform.Find ("detail").gameObject.GetComponent<Text> ();
		}
	}

}

