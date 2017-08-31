using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class galleryButton : MonoBehaviour {
 	public GameObject Panel;
	public GameObject disableman;
	public GameObject ActiveButton;
	public GameObject galleryUI;
	GameObject gt;
	// Use this for initialization

	public void OnClick(){
		galleryUI.gameObject.SetActive (true);
		gt = GameObject.Find ("CGobjects");
		gt.GetComponent<unableee> ().ButtonOn ();
		

	}
}