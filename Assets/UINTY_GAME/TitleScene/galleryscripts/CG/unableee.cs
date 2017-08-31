using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class unableee : MonoBehaviour {
	
	Button[] bt;

	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ButtonOff () {
		bt = GetComponentsInChildren <Button> ();
		for (int i = 0; i < bt.Length; i++) {
			bt [i].enabled = false;
		}
	}

	public void ButtonOn () {
		bt = GetComponentsInChildren <Button> ();
		for (int i = 0; i < bt.Length; i++) {
			bt [i].enabled = true;
		}
	}
}
