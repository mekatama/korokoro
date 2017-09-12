using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_GoalTime : MonoBehaviour {
	public Text goalTime;		//ゴールタイムを表示するオブジェクト用
	GameObject gameController;	//検索したオブジェクト入れる用

	void Start () {
		gameController = GameObject.FindWithTag ("GameController");	//GameControllerオブジェクトを探す
	}
	
	void Update () {
		//gcって仮の変数にGameControllerのコンポーネントを入れる
		GameController gc = gameController.GetComponent<GameController>();

		//Main0用
		if(SceneManager.GetActiveScene ().name == "Main0"){
			//ハイスコアの保存(タイム)
			if(PlayerPrefs.GetFloat("HighScoreTime0") < gc.finishTime){
				goalTime.text = "CrearTime : " + gc.finishTime.ToString("000.000") + "(NewRecord)";	
			}else{
				goalTime.text = "CrearTime : " + gc.finishTime.ToString("000.000");	
			}
		}
		//Main1用
		if(SceneManager.GetActiveScene ().name == "Main1"){
			//ハイスコアの保存(タイム)
			if(PlayerPrefs.GetFloat("HighScoreTime1") < gc.finishTime){
				goalTime.text = "CrearTime : " + gc.finishTime.ToString("000.000") + "(NewRecord)";	
			}else{
				goalTime.text = "CrearTime : " + gc.finishTime.ToString("000.000");	
			}
		}
		//Main2用
		if(SceneManager.GetActiveScene ().name == "Main2"){
			//ハイスコアの保存(タイム)
			if(PlayerPrefs.GetFloat("HighScoreTime2") < gc.finishTime){
				goalTime.text = "CrearTime : " + gc.finishTime.ToString("000.000") + "(NewRecord)";	
			}else{
				goalTime.text = "CrearTime : " + gc.finishTime.ToString("000.000");	
			}
		}
		//Main3用
		if(SceneManager.GetActiveScene ().name == "Main3"){
			//ハイスコアの保存(タイム)
			if(PlayerPrefs.GetFloat("HighScoreTime3") < gc.finishTime){
				goalTime.text = "CrearTime : " + gc.finishTime.ToString("000.000") + "(NewRecord)";	
			}else{
				goalTime.text = "CrearTime : " + gc.finishTime.ToString("000.000");	
			}
		}
		//Main4用
		if(SceneManager.GetActiveScene ().name == "Main4"){
			//ハイスコアの保存(タイム)
			if(PlayerPrefs.GetFloat("HighScoreTime4") < gc.finishTime){
				goalTime.text = "CrearTime : " + gc.finishTime.ToString("000.000") + "(NewRecord)";	
			}else{
				goalTime.text = "CrearTime : " + gc.finishTime.ToString("000.000");	
			}
		}
	}
}
