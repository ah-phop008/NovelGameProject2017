using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageChange : MonoBehaviour {

	public void ChangePage () {
		int num;
		string name = this.gameObject.name;

		name = name.Remove (0, 4);
		num = int.Parse (name);
		//ページ番号更新
		GameObject.Find ("SaveCanvas").GetComponent<SaveScreen> ().pageNum = num;
		GameObject.Find ("SaveCanvas").GetComponent<SaveScreen> ().UpdateSavedata ();


		for (int i = 0; i < 4; i++) {
			GameObject.Find ("SaveCanvas").transform.Find ("page").transform.Find ("page" + i).Find ("select").gameObject.GetComponent<Image> ().enabled = false;
		}
		this.transform.Find ("select").GetComponent <Image> ().enabled = true;
	}
}
