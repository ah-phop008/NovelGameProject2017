using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Novel;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour {

	//int i;
	public int[] i;

	// Use this for initialization
	void Start () {
		/*
		GameObject g = Resources.Load ("Sprite") as GameObject;
		Instantiate (g);
		*/
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKeyDown (KeyCode.A)) {
			PlayerPrefsX.SetIntArray ("testArray", i);
			Debug.Log ("save complete");
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			i = PlayerPrefsX.GetIntArray ("testArray");
			for (int j = 0; j < i.Length; j++) Debug.Log (i[j]);
			Debug.Log ("load complete");
		}

		/*
		if (Input.GetKeyDown (KeyCode.A)) {
			//SceneManager.LoadScene ("Player", LoadSceneMode.Additive);
			NovelSingleton.StatusManager.callJoker("wide/libs/save", "loadstart");

		}
		if (Input.GetKeyDown (KeyCode.B)) {
			StatusManager.enableNextOrder = true;

			StatusManager.FlagSkiiping = true;
			StartCoroutine("Loop",0.1f);

		}

		/*
		if (Input.GetMouseButtonDown (1)) {
			string s = "save_" + i;
			StatusManager.nextLoad = s;
			Application.LoadLevel ("Player");
		}
		if (Input.GetKeyDown (KeyCode.F1)) i = 0;
		if (Input.GetKeyDown (KeyCode.F2)) i = 1;
		if (Input.GetKeyDown (KeyCode.F3)) i = 2;
		if (Input.GetKeyDown (KeyCode.F4)) i = 3;
		Debug.Log ("set num " + i);
		*/
	}
}
