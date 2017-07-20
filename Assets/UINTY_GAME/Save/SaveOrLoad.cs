using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveOrLoad : MonoBehaviour {

	public void saveload () {
		int num;
		string name = this.gameObject.name;
		//save_0はオートセーブ用
		name = name.Remove (0, 6);
		num = GameObject.Find ("SaveCanvas").GetComponent<SaveScreen> ().pageNum * 6 + int.Parse(name);
		GameObject.Find ("SaveCanvas").GetComponent<SaveScreen> ().SaveLoadData (num);
	}
}
