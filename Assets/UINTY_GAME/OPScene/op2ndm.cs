using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using Novel;

public class op2ndm : MonoBehaviour {

	VideoPlayer v;
	// Use this for initialization
	void Start () {
		v = GetComponent<VideoPlayer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
			NovelSingleton.StatusManager.callJoker("wide/chap4-1","");
	}
}
