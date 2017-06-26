using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cgf1manager : MonoBehaviour {
	GameObject parent;
	// Use this for initialization

	public void OnClick() {
		
		parent = transform.parent.gameObject;
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
