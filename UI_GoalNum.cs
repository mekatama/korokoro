using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_GoalNum : MonoBehaviour {
	public Text goalNum;		//player数を表示するオブジェクト用
	GameObject gameController;	//検索したオブジェクト入れる用

	void Start () {
		gameController = GameObject.FindWithTag ("GameController");	//GameControllerオブジェクトを探す
	}
	
	void Update () {
		//gcって仮の変数にGameControllerのコンポーネントを入れる
		GameController gc = gameController.GetComponent<GameController>();

		//Main0用
		if(SceneManager.GetActiveScene ().name == "Main0"){
			//ハイスコアの保存(匹数)
			if(PlayerPrefs.GetInt("HighScorePlayer0") < gc.totalPlayer){
				goalNum.text = "IKINOKORI : " + gc.totalPlayer.ToString("00") + "(NewRecord)";	
			}else{
				goalNum.text = "IKINOKORI : " + gc.totalPlayer.ToString("00");	
			}
		}
		//Main1用
		if(SceneManager.GetActiveScene ().name == "Main1"){
			//ハイスコアの保存(匹数)
			if(PlayerPrefs.GetInt("HighScorePlayer1") < gc.totalPlayer){
				goalNum.text = "IKINOKORI : " + gc.totalPlayer.ToString("00") + "(NewRecord)";	
			}else{
				goalNum.text = "IKINOKORI : " + gc.totalPlayer.ToString("00");	
			}
		}
		//Main2用
		if(SceneManager.GetActiveScene ().name == "Main2"){
			//ハイスコアの保存(匹数)
			if(PlayerPrefs.GetInt("HighScorePlayer2") < gc.totalPlayer){
				goalNum.text = "IKINOKORI : " + gc.totalPlayer.ToString("00") + "(NewRecord)";	
			}else{
				goalNum.text = "IKINOKORI : " + gc.totalPlayer.ToString("00");	
			}
		}
		//Main3用
		if(SceneManager.GetActiveScene ().name == "Main3"){
			//ハイスコアの保存(匹数)
			if(PlayerPrefs.GetInt("HighScorePlayer3") < gc.totalPlayer){
				goalNum.text = "IKINOKORI : " + gc.totalPlayer.ToString("00") + "(NewRecord)";	
			}else{
				goalNum.text = "IKINOKORI : " + gc.totalPlayer.ToString("00");	
			}
		}
		//Main4用
		if(SceneManager.GetActiveScene ().name == "Main4"){
			//ハイスコアの保存(匹数)
			if(PlayerPrefs.GetInt("HighScorePlayer4") < gc.totalPlayer){
				goalNum.text = "IKINOKORI : " + gc.totalPlayer.ToString("00") + "(NewRecord)";	
			}else{
				goalNum.text = "IKINOKORI : " + gc.totalPlayer.ToString("00");	
			}
		}
	}
}
