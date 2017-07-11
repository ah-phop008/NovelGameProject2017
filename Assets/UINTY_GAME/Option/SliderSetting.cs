using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderSetting : MonoBehaviour {

	Slider s;
	// Use this for initialization
	void Start () {
		s = GetComponent<Slider> ();
		if (this.gameObject.name == "MessageSpeedSlider") {
			s.value = 110 - 1000 * SystemManager.messageSpeed;
		} else if (this.gameObject.name == "AutoWaitSlider") {
			s.value = 100 - 25 * SystemManager.AutoMessageWait;
		}
	}

	public void MoveMessageSlider () {
		SystemManager.messageSpeed = (float)(0.01 + (100 - s.value) / 1000);
	}

	public void MoveAutoSlider () {
		SystemManager.AutoMessageWait = (100 - s.value) / 25;
	}
	
}
