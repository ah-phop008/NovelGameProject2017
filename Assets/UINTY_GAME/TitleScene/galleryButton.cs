using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class galleryButton : MonoBehaviour {
 	public GameObject Panel;
	public GameObject disableman;
	public GameObject ActiveButton;
	public GameObject galleryUI;
	// Use this for initialization
	public void OnClick(){
		galleryUI.gameObject.SetActive (true);
		



}
}