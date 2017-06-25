using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Novel{

	public class JoinComponent:AbstractComponent
	{
		public JoinComponent ()
		{

			//必須項目
			this.arrayVitalParam = new List<string> {
				"var","arg1","arg2"
			};

			this.originalParam = new Dictionary<string,string> () {
				{"var",""},
				{"arg1",""},
				{"arg2",""},
			};

		}


		public override void start ()
		{

			string var_name = this.param ["var"];
			string arg1 = this.param ["arg1"];
			string arg2 = this.param ["arg2"];

			string arg_result = arg1 + arg2;

			string testString = this.param ["var"];

			//変数に結果を格納
			StatusManager.variable.set (var_name, arg_result);
			//これと同義
			//StatusManager.variable.set (this.param["var"], arg_result);

			//次のシナリオに進む処理
			this.gameManager.nextOrder ();

		}

	}

	public class LogComponent:AbstractComponent
	{
		public LogComponent ()
		{
			//必須項目
			this.arrayVitalParam = new List<string> {
				"text"
			};

			this.originalParam = new Dictionary<string,string> () {
				{"text",""}
			};
		}

		public override void start ()
		{

			Debug.Log(this.param ["text"]);

			//次のシナリオに進む処理
			//this.gameManager.nextOrder ();

		}
	}


	public class LoadunitysceneComponent:AbstractComponent
	{
		public LoadunitysceneComponent ()
		{

			//必須項目
			this.arrayVitalParam = new List<string> {
				"name"
			};

			this.originalParam = new Dictionary<string,string> () {
				{"name",""},
			};

		}


		public override void start ()
		{

			string scene_name = this.param ["name"];

			UnityEngine.SceneManagement.SceneManager.LoadScene (scene_name);
			//次のシナリオに進む処理
			this.gameManager.nextOrder ();

		}

	}

}