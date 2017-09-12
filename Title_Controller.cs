using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Title_Controller : MonoBehaviour {
	GameObject gameController;	//検索したオブジェクト入れる用

	void Start () {
		gameController = GameObject.FindWithTag ("GameController");	//GameControllerオブジェクトを探す
	}

	void Update(){
		//backキー
		if (Input.GetKeyUp(KeyCode.Escape)){
			Application.Quit();	//アプリ終了
		}
	}


	//スタートボタン(Normal)用の制御関数
	public void OnStartButtonNormalClicked(){
		SceneManager.LoadScene("StageSelect");	//シーンのロード
	}

	//スタートボタン(Expert)用の制御関数
	public void OnStartButtonExpertClicked(){
		SceneManager.LoadScene("Main0");	//シーンのロード
	}

	//遊び方ボタン用の制御関数
	public void OnHowToPlayButtonClicked(){
		SceneManager.LoadScene("HowToPlay");	//シーンのロード
	}

	//タイトルに戻るボタン用の制御関数
	public void OnReturnTitleButtonClicked(){
		//gcって仮の変数にGameControllerのコンポーネントを入れる
		GameController gc = gameController.GetComponent<GameController>();
		//Main0用
		if(SceneManager.GetActiveScene ().name == "Main0"){
			//ハイスコアの保存(匹数)
			if(PlayerPrefs.GetInt("HighScorePlayer0") < gc.totalPlayer){
				//ハイスコア保存
				PlayerPrefs.SetInt("HighScorePlayer0", gc.totalPlayer);
				Debug.Log("HighScorePlayer0:" + PlayerPrefs.GetInt("HighScorePlayer0"));
			}
			//ハイスコアの保存(タイム)
			if(PlayerPrefs.GetFloat("HighScoreTime0") < gc.finishTime){
				//ハイスコア保存
				PlayerPrefs.SetFloat("HighScoreTime0", gc.finishTime);
				Debug.Log("HighScoreTime0:" + PlayerPrefs.GetFloat("HighScoreTime0"));
			}
		}
		//Main1用
		if(SceneManager.GetActiveScene ().name == "Main1"){
			//ハイスコアの保存(匹数)
			if(PlayerPrefs.GetInt("HighScorePlayer1") < gc.totalPlayer){
				//ハイスコア保存
				PlayerPrefs.SetInt("HighScorePlayer1", gc.totalPlayer);
				Debug.Log("HighScorePlayer1:" + PlayerPrefs.GetInt("HighScorePlayer1"));
			}
			//ハイスコアの保存(タイム)
			if(PlayerPrefs.GetFloat("HighScoreTime1") < gc.finishTime){
				//ハイスコア保存
				PlayerPrefs.SetFloat("HighScoreTime1", gc.finishTime);
				Debug.Log("HighScoreTime1:" + PlayerPrefs.GetFloat("HighScoreTime1"));
			}
		}
		//Main2用
		if(SceneManager.GetActiveScene ().name == "Main2"){
			//ハイスコアの保存(匹数)
			if(PlayerPrefs.GetInt("HighScorePlayer2") < gc.totalPlayer){
				//ハイスコア保存
				PlayerPrefs.SetInt("HighScorePlayer2", gc.totalPlayer);
				Debug.Log("HighScorePlayer2:" + PlayerPrefs.GetInt("HighScorePlayer2"));
			}
			//ハイスコアの保存(タイム)
			if(PlayerPrefs.GetFloat("HighScoreTime2") < gc.finishTime){
				//ハイスコア保存
				PlayerPrefs.SetFloat("HighScoreTime2", gc.finishTime);
				Debug.Log("HighScoreTime2:" + PlayerPrefs.GetFloat("HighScoreTime2"));
			}
		}
		//Main3用
		if(SceneManager.GetActiveScene ().name == "Main3"){
			//ハイスコアの保存(匹数)
			if(PlayerPrefs.GetInt("HighScorePlayer3") < gc.totalPlayer){
				//ハイスコア保存
				PlayerPrefs.SetInt("HighScorePlayer3", gc.totalPlayer);
				Debug.Log("HighScorePlayer3:" + PlayerPrefs.GetInt("HighScorePlayer3"));
			}
			//ハイスコアの保存(タイム)
			if(PlayerPrefs.GetFloat("HighScoreTime3") < gc.finishTime){
				//ハイスコア保存
				PlayerPrefs.SetFloat("HighScoreTime3", gc.finishTime);
				Debug.Log("HighScoreTime3:" + PlayerPrefs.GetFloat("HighScoreTime3"));
			}
		}
		//Main4用
		if(SceneManager.GetActiveScene ().name == "Main4"){
			//ハイスコアの保存(匹数)
			if(PlayerPrefs.GetInt("HighScorePlayer4") < gc.totalPlayer){
				//ハイスコア保存
				PlayerPrefs.SetInt("HighScorePlayer4", gc.totalPlayer);
				Debug.Log("HighScorePlayer4:" + PlayerPrefs.GetInt("HighScorePlayer4"));
			}
			//ハイスコアの保存(タイム)
			if(PlayerPrefs.GetFloat("HighScoreTime4") < gc.finishTime){
				//ハイスコア保存
				PlayerPrefs.SetFloat("HighScoreTime4", gc.finishTime);
				Debug.Log("HighScoreTime4:" + PlayerPrefs.GetFloat("HighScoreTime4"));
			}
		}

		SceneManager.LoadScene("Title");	//シーンのロード
	}
	
	//アプリ終了
	public void OnExitButtonClicked(){
		Application.Quit();
		Debug.Log("exit");
	}
}
