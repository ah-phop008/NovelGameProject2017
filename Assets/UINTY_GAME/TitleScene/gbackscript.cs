using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gbackscript : MonoBehaviour {

	public GameObject Panel;
	public GameObject disableman;

	// Use this for initialization
	// Update is called once per frame

		public void OnClick() {
			Debug.Log ("button click!");
		Panel.GetComponent<fader> ().bflag = false; 
		disableman.gameObject.SetActive (true);
			
}
}
