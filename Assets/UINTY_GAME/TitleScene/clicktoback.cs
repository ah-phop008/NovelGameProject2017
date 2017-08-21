using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clicktoback : MonoBehaviour {
	public GameObject ALL;
	public GameObject click;
	public GameObject VideoSource;
	public GameObject maincamera;

	public void onclick() {
		ALL.gameObject.SetActive (true);
		VideoSource.gameObject.SetActive (false);
		click.gameObject.SetActive (false);
		maincamera.SendMessage ("startmaintheme");
	}


}
