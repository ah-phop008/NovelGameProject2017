﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class opManaer : MonoBehaviour {

	VideoPlayer v;
	// Use this for initialization
	void Start () {
		v = GetComponent<VideoPlayer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!v.isPlaying || Input.GetMouseButtonDown(0))
			SceneManager.LoadScene ("title");
	}
}
