using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gbackscript : MonoBehaviour {

	public GameObject Panel;
	GameObject parent;

	// Use this for initialization
	// Update is called once per frame


		public void OnClick() {
			Debug.Log ("button click!");
			parent = transform.parent.gameObject;
			Panel.GetComponent<fader> ().bflag = false; 
			
}
}
