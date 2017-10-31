using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

namespace Novel{
	public class MovieComponent : AbstractComponent {

		// public MovieComponent(){
		// 	this.arrayVitalParam = new List<string> {
		// 		"path", "skip"
		// };
		// 	this.originalParam = new Dictionary<string,string> () {
		// 		{"path",""},
		// 		{"skip", ""}
		// 	};
		// }

		public MovieComponent(){
			this.arrayVitalParam = new List<string> {
				"path"
		};
			this.originalParam = new Dictionary<string,string> () {
				{"path",""}
			};
		}

		public override void start () {

			string path = this.param["path"];

			GameObject canvas = GameObject.Find("Canvas");

			GameObject prefab = (GameObject)Resources.Load("Prefabs/MovieJKS");

			prefab.GetComponent<RectTransform>().sizeDelta
			 = canvas.GetComponent<RectTransform>().sizeDelta;

			GameObject movieJKS = GameObject.Instantiate(prefab);

			// スクリプトのメソッド呼び出し
			MovieUI movieOnUI = movieJKS.GetComponent<MovieUI>();
			movieOnUI.initMovie(path);

			bool isSkip = true;
			// Debug.Log(this.param["skip"]);
			isSkip = System.Convert.ToBoolean(this.param["skip"]);
			movieOnUI.setIsSkip(isSkip);
			movieJKS.gameObject.name = "movie_jks";

			movieJKS.transform.SetParent(canvas.transform, false);
			
			this.gameManager.startTag("[l]");
		}
	}
}
