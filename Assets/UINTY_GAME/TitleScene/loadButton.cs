using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Novel;
using UnityEngine.UI;

public class loadButton : MonoBehaviour {

	public GameObject Panel;
	GameObject parent;

	public void onclick() {

		parent = transform.parent.gameObject;
		Panel.GetComponent<fader> ().lflag = false; 
		for(int i=0; i< parent.transform.childCount; i++)
		{
			GameObject child = parent.transform.GetChild(i).gameObject;
			if (child != null) {
				//child.setActive(false);
				child.GetComponent<Button> ().enabled = false;
				Debug.Log (i);
			}
	


	}

}
}
