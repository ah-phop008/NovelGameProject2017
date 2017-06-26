using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class galleryButton : MonoBehaviour {
 	public GameObject Panel;
	public GameObject disableman;
	// Use this for initialization
	public void OnClick(){
		
		Panel.GetComponent<fader> ().gflag = false;
		disableman.gameObject.SetActive (true);


}
}