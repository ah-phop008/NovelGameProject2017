using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Novel;

public class SaveScreen : MonoBehaviour {

	public int pageNum = 0;
	int savedataNum;
	public bool LoadMode = true;

	SaveData[] data = new SaveData[6];

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 6; i++) { 
			data [i] = new SaveData ();
			data[i].GetSavedataText (transform.Find ("data/data" + (i + 1)).gameObject);
		}
		putSavedata ((int)pageNum);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//セーブデータの情報を取得
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
		if (pageNum > 2) {
			pageNum = 0;
		} else if (pageNum < 0) {
			pageNum = 2;
		}
		putSavedata (pageNum);
	}


	public void ChangeStoL () {
		//ロードモードへ
		Texture2D tex = Resources.Load ("load.png") as Texture2D;
		UnityEngine.UI.Image[] objs = this.transform.Find ("SaveLoad").gameObject.GetComponentsInChildren<UnityEngine.UI.Image> ();
		for (int i = 0; i < objs.Length; i++) {
			objs [i].sprite = Sprite.Create (tex, new Rect (0, 0, tex.width, tex.height), Vector2.zero);
		}
		//backgroundも変更
	}
	public void ChangeLtoS () {
		//セーブモードへ
		Texture2D tex = Resources.Load ("save.png") as Texture2D;
		UnityEngine.UI.Image[] objs = this.transform.Find ("SaveLoad").gameObject.GetComponentsInChildren<UnityEngine.UI.Image> ();
		for (int i = 0; i < objs.Length; i++) {
			objs [i].sprite = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), Vector2.zero);
		}
		//backgroundも変更
	}



}

public class SaveData {
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
