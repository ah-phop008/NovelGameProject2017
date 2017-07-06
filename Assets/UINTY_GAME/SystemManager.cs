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
			PlayerPrefsX.SetBool ("onceClear", false);
			//optionのフラグ
			PlayerPrefs.SetFloat("messageSpeed", 0.1f);
			//ルートのフラグ

			//初回起動フラグをoff
			FistRunTime = false;
			PlayerPrefsX.SetBool ("FirstRunTime", false);
		} else {
			//CGデータのロード
			Chara1_CG = PlayerPrefsX.GetBoolArray ("Chara1CG");
			Chara2_CG = PlayerPrefsX.GetBoolArray ("Chara2CG");
			Chara3_CG = PlayerPrefsX.GetBoolArray ("Chara3CG");
			Chara4_CG = PlayerPrefsX.GetBoolArray ("Chara4CG");
			Chara5_CG = PlayerPrefsX.GetBoolArray ("Chara5CG");
			Chara6_CG = PlayerPrefsX.GetBoolArray ("Chara6CG");
			//クリアフラグのロード
			ClearFlag = PlayerPrefsX.GetBoolArray ("ClearFlag");
			onceClear = PlayerPrefsX.GetBool ("onceClear");
			//optionのロード
			messageSpeed = PlayerPrefs.GetFloat("messageSpeed");
			//ルートのフラグのロード

		}
	}

	//セーブデータ初期化
	public static void InitSystemData() {
		PlayerPrefsX.SetBool ("FirstRunTime", true);
		Application.Quit ();
	}


	//各システムデータのセーブ
	public static void SaveChara1CG() {
		PlayerPrefsX.SetBoolArray ("Chara1CG", Chara1_CG);
	}
	public static void SaveChara2CG() {
		PlayerPrefsX.SetBoolArray ("Chara2CG", Chara2_CG);
	}
	public static void SaveChara3CG() {
		PlayerPrefsX.SetBoolArray ("Chara3CG", Chara3_CG);
	}
	public static void SaveChara4CG() {
		PlayerPrefsX.SetBoolArray ("Chara4CG", Chara4_CG);
	}
	public static void SaveChara5CG() {
		PlayerPrefsX.SetBoolArray ("Chara5CG", Chara5_CG);
	}
	public static void SaveChara6CG() {
		PlayerPrefsX.SetBoolArray ("Chara6CG", Chara6_CG);
	}
	public static void SaveClearFlg() {
		PlayerPrefsX.SetBoolArray ("ClearFlg", ClearFlag);
	}
}
