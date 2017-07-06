using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class charamanager : MonoBehaviour {
	public GameObject cgp1;
	public GameObject cgp2;
	public GameObject cgp3;
	public GameObject cgp4;
	public GameObject cgp5;
	public GameObject cgp6;
	public GameObject CGobjects;


	public void OnClick() {
		CGobjects.BroadcastMessage ("zero");
		cgp6.gameObject.SetActive (true);

	}

	void del() {
		cgp1.gameObject.SetActive (false);
		cgp2.gameObject.SetActive (false);
		cgp3.gameObject.SetActive (false);
		cgp4.gameObject.SetActive (false);
		cgp5.gameObject.SetActive (false);
	}
}
