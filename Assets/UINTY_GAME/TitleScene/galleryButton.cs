using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class galleryButton : MonoBehaviour {
 	public GameObject Panel;
	  GameObject parent;
	// Use this for initialization
	public void OnClick(){
		parent = transform.parent.gameObject;
		Panel.GetComponent<fader> ().gflag = false; 

}
}