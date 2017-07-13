using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemManager : MonoBehaviour {
	//初回起動かどうか
	private static bool FistRunTime;
	//CGのアンロックフラグ
	public static bool[] Chara1_CG = new bool[5];
	public static bool[] Chara2_CG = new bool[5];
	public static bool[] Chara3_CG = new bool[5];
	public static bool[] Chara4_CG = new bool[5];
	public static bool[] Chara5_CG = new bool[5];
	public static bool[] Chara6_CG = new bool[5];
	//各シナリオのクリアフラグ
	public static bool[] ClearFlag = new bool[6];
	//1度どれかのシナリオをクリアしたかどうかのフラグ
	public static bool onceClear;
	//option設定値
	public static float messageSpeed;
	public static float AutoMessageWait;




	//ゲーム起動時に実行。システムデータのロード開始
	public static void LoadSystemData() {
		FistRunTime = PlayerPrefsX.GetBool ("FirstRunTime");

		if (FistRunTime) {
			//システムデータの初期化
			//CGデータの初期化
			bool[] reset = new bool[5];
			PlayerPrefsX.SetBoolArray ("Chara1CG", reset);
			PlayerPrefsX.SetBoolArray ("Chara2CG", reset);
			PlayerPrefsX.SetBoolArray ("Chara3CG", reset);
			PlayerPrefsX.SetBoolArray ("Chara4CG", reset);
			PlayerPrefsX.SetBoolArray ("Chara5CG", reset);
			PlayerPrefsX.SetBoolArray ("Chara6CG", reset);
			//クリアフラグの初期化
			reset = new bool[6];
			PlayerPrefsX.SetBoolArray ("ClearFlag", reset);
			PlayerPrefsX.SetBool ("onceClear", reset[0]);
			//optionのフラグ
			PlayerPrefs.SetFloat("messageSpeed", 0.1f);
			PlayerPrefs.SetFloat ("AutoMessageWait", 2.0f);
			//ルートのフラグ

			//初回起動フラグをoff
			FistRunTime = false;
			PlayerPrefsX.SetBool ("FirstRunTime", FistRunTime);
			Debug.Log ("システムデータを初期化しました");
		} else {
			//CGデータのロード
			string log = "";

			Chara1_CG = PlayerPrefsX.GetBoolArray ("Chara1CG");
			for (int t = 0; t < Chara1_CG.Length; t++) log += Chara1_CG [t] + ", ";
			Debug.Log ("Chara1CG : " + log);
			Chara2_CG = PlayerPrefsX.GetBoolArray ("Chara2CG");
			log = "";
			for (int t = 0; t < Chara1_CG.Length; t++) log += Chara1_CG [t] + ", ";
			Debug.Log ("Chara2CG : " + log);
			Chara3_CG = PlayerPrefsX.GetBoolArray ("Chara3CG");
			log = "";
			for (int t = 0; t < Chara1_CG.Length; t++) log += Chara1_CG [t] + ", ";
			Debug.Log ("Chara3CG : " + log);
			Chara4_CG = PlayerPrefsX.GetBoolArray ("Chara4CG");
			log = "";
			for (int t = 0; t < Chara1_CG.Length; t++) log += Chara1_CG [t] + ", ";
			Debug.Log ("Chara4CG : " + log);
			Chara5_CG = PlayerPrefsX.GetBoolArray ("Chara5CG");
			log = "";
			for (int t = 0; t < Chara1_CG.Length; t++) log += Chara1_CG [t] + ", ";
			Debug.Log ("Chara5CG : " + log);
			Chara6_CG = PlayerPrefsX.GetBoolArray ("Chara6CG");
			log = "";
			for (int t = 0; t < Chara1_CG.Length; t++) log += Chara1_CG [t] + ", ";
			Debug.Log ("Chara6CG : " + log);
			//クリアフラグのロード
			ClearFlag = PlayerPrefsX.GetBoolArray ("ClearFlag");
			log = "";
			for (int t = 0; t < ClearFlag.Length; t++) log += ClearFlag [t] + ", ";
			Debug.Log ("ClearFlg : {" + log + "}");
			onceClear = PlayerPrefsX.GetBool ("onceClear");
			Debug.Log ("onceClear : " + onceClear);
			//optionのロード
			messageSpeed = PlayerPrefs.GetFloat("messageSpeed");
			Debug.Log ("messageSpeed : " + messageSpeed);
			AutoMessageWait = PlayerPrefs.GetFloat ("AutoMessageWait");
			Debug.Log ("AutoMessageWait : " + AutoMessageWait);
			//ルートのフラグのロード

			Debug.Log ("システムデータをロードしました");
		}
	}

	//セーブデータ初期化
	public static void InitSystemData() {
		PlayerPrefsX.SetBool ("FirstRunTime", true);
		Debug.Log ("システムデータを初期化する準備が整いました");
		Application.Quit ();
	}


	//各システムデータのセーブ
	public static void SaveChara1CG() {
		PlayerPrefsX.SetBoolArray ("Chara1CG", Chara1_CG);
		Debug.Log ("Chara1CGをセーブしました");
	}
	public static void SaveChara2CG() {
		PlayerPrefsX.SetBoolArray ("Chara2CG", Chara2_CG);
		Debug.Log ("Chara2CGをセーブしました");
	}
	public static void SaveChara3CG() {
		PlayerPrefsX.SetBoolArray ("Chara3CG", Chara3_CG);
		Debug.Log ("Chara3CGをセーブしました");
	}
	public static void SaveChara4CG() {
		PlayerPrefsX.SetBoolArray ("Chara4CG", Chara4_CG);
		Debug.Log ("Chara4CGをセーブしました");
	}
	public static void SaveChara5CG() {
		PlayerPrefsX.SetBoolArray ("Chara5CG", Chara5_CG);
		Debug.Log ("Chara5CGをセーブしました");
	}
	public static void SaveChara6CG() {
		PlayerPrefsX.SetBoolArray ("Chara6CG", Chara6_CG);
		Debug.Log ("Chara6CGをセーブしました");
	}
	public static void SaveClearFlg() {
		PlayerPrefsX.SetBoolArray ("ClearFlg", ClearFlag);
		Debug.Log ("ClearFlgをセーブしました");
	}
	public static void SaveOption () {
		//optionのセーブ
		PlayerPrefs.SetFloat("messageSpeed", messageSpeed);
		Debug.Log ("messageSpeedをセーブしました");
		PlayerPrefs.SetFloat ("AutoMessageWait", AutoMessageWait);
		Debug.Log ("AutoMessageWaitをセーブしました");
	}
}
