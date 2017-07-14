using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Novel;

public class SaveScreen : MonoBehaviour {

	public int pagenum = 0;
	int savedataNum;

	SaveData[] data = new SaveData[6];

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 6; i++) { 
			data [i] = new SaveData ();
			data[i].GetSavedataText (transform.Find ("data" + (i + 1)).gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//セーブデータの情報を取得
	void putSavedata (int pagenum) {
		string name;
		SaveObject obj;
		for (int i = 0; i < 6; i++) {
			name = "save_" + (pagenum * 6 + i + 1);
			obj = NovelSingleton.SaveManager.getSaveData (name);
		}
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
