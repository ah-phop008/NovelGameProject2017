using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startButton : MonoBehaviour {
	public GameObject Panel;
	GameObject parent;
	// Use this for initialization

	public void OnClick() {
		Debug.Log ("button click!");
		parent = transform.parent.gameObject;
		Panel.GetComponent<fader> ().sflag = false; 
		for(int i=0; i< parent.transform.childCount; i++)
		{
			GameObject child = parent.transform.GetChild(i).gameObject;
			if (child != null) {
				//child.setActive(false);
				child.GetComponent<Button> ().enabled=false;
				Debug.Log (i);
			}
		}
	}
}
