using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Novel;

public class StartSkip : MonoBehaviour {

	public void Skipstart () {
		
		AbstractComponent cmp = null;

		Type masterType = Type.GetType ("Novel.SkipstartComponent");
		cmp = (AbstractComponent)Activator.CreateInstance (masterType);


		cmp.before ();

		if (StatusManager.skipOrder == false) {

			cmp.calcVariable ();
			cmp.validate ();
			string p = "";
			foreach (KeyValuePair<string, string> kvp in cmp.param) {
				p += kvp.Key + "=" + kvp.Value + " ";
			}

			Debug.Log ("[" + cmp.tagName + " " + p + "]");

			cmp.start ();
			cmp.after ();
		}
	}
}
