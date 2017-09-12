using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_StageSelect : MonoBehaviour {
	public Text playerNum1;		//player数ハイスコアを表示するオブジェクト用
	public Text playerNum2;		//player数ハイスコアを表示するオブジェクト用
	public Text playerNum3;		//player数ハイスコアを表示するオブジェクト用
	public Text playerNum4;		//player数ハイスコアを表示するオブジェクト用
	public Text clearTime1;		//ハイスコアTimeを表示するオブジェクト用
	public Text clearTime2;		//ハイスコアTimeを表示するオブジェクト用
	public Text clearTime3;		//ハイスコアTimeを表示するオブジェクト用
	public Text clearTime4;		//ハイスコアTimeを表示するオブジェクト用

	void Update () {
		//ハイスコア系テキストの表示
		playerNum1.text = "Player : " + PlayerPrefs.GetInt("HighScorePlayer1").ToString("000");	
		clearTime1.text = "Time : " + PlayerPrefs.GetFloat("HighScoreTime1").ToString("000.00");	
		playerNum2.text = "Player : " + PlayerPrefs.GetInt("HighScorePlayer2").ToString("000");	
		clearTime2.text = "Time : " + PlayerPrefs.GetFloat("HighScoreTime2").ToString("000.00");	
		playerNum3.text = "Player : " + PlayerPrefs.GetInt("HighScorePlayer3").ToString("000");	
		clearTime3.text = "Time : " + PlayerPrefs.GetFloat("HighScoreTime3").ToString("000.00");	
		playerNum4.text = "Player : " + PlayerPrefs.GetInt("HighScorePlayer4").ToString("000");	
		clearTime4.text = "Time : " + PlayerPrefs.GetFloat("HighScoreTime4").ToString("000.00");	
	}
}
