using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	public int totalPlayer = 0;			//ここでplayer数を管理していく
	public GameObject player;			//playerを入れる
	private float bgCreate = -6.0f;		//次のBG生成を判定する座標
	private float bgCreate_posX = 18.0f;//次のBG生成する座標
	private float bgCreate_posY = -1.6f;//次のBG生成する座標
	public GameObject[] bgObject;		//BGプレハブ。一応、配列で管理
	public GameObject bgObjectGoal;		//GOAL用BGプレハブ
	public float timePlaying;			//経過時間
	public float goalBg;				//goal用BGが出現する判定
	public float finishTime;			//ゴール時のタイムを保存

	void Start () {
	}
	
	void Update () {
		//経過時間チェック
		timePlaying += Time.deltaTime;	//経過時間の保存
		//pcって仮の変数にplayerコンポーネントを入れる
		Player pc = player.GetComponent<Player>();

		//ゴール時の処理
		if(pc.goalTiming){
			finishTime = timePlaying;	//ゴール時のタイムを保存
			//Main0用
			if(SceneManager.GetActiveScene ().name == "Main0"){
				//ハイスコアの保存(匹数)
				if(PlayerPrefs.GetInt("HighScorePlayer0") < totalPlayer){
					//ハイスコア保存
					PlayerPrefs.SetInt("HighScorePlayer0", totalPlayer);
					Debug.Log("HighScorePlayer0:" + PlayerPrefs.GetInt("HighScorePlayer0"));
				}
				//ハイスコアの保存(タイム)
				if(PlayerPrefs.GetFloat("HighScoreTime0") < finishTime){
					//ハイスコア保存
					PlayerPrefs.SetFloat("HighScoreTime0", finishTime);
					Debug.Log("HighScoreTime0:" + PlayerPrefs.GetFloat("HighScoreTime0"));
				}
			}
			//Main1用
			if(SceneManager.GetActiveScene ().name == "Main1"){
				//ハイスコアの保存(匹数)
				if(PlayerPrefs.GetInt("HighScorePlayer1") < totalPlayer){
					//ハイスコア保存
					PlayerPrefs.SetInt("HighScorePlayer1", totalPlayer);
					Debug.Log("HighScorePlayer1:" + PlayerPrefs.GetInt("HighScorePlayer1"));
				}
				//ハイスコアの保存(タイム)
				if(PlayerPrefs.GetFloat("HighScoreTime1") < finishTime){
					//ハイスコア保存
					PlayerPrefs.SetFloat("HighScoreTime1", finishTime);
					Debug.Log("HighScoreTime1:" + PlayerPrefs.GetFloat("HighScoreTime1"));
				}
			}
			//Main2用
			if(SceneManager.GetActiveScene ().name == "Main2"){
				//ハイスコアの保存(匹数)
				if(PlayerPrefs.GetInt("HighScorePlayer2") < totalPlayer){
					//ハイスコア保存
					PlayerPrefs.SetInt("HighScorePlayer2", totalPlayer);
					Debug.Log("HighScorePlayer2:" + PlayerPrefs.GetInt("HighScorePlayer2"));
				}
				//ハイスコアの保存(タイム)
				if(PlayerPrefs.GetFloat("HighScoreTime2") < finishTime){
					//ハイスコア保存
					PlayerPrefs.SetFloat("HighScoreTime2", finishTime);
					Debug.Log("HighScoreTime2:" + PlayerPrefs.GetFloat("HighScoreTime2"));
				}
			}
			//Main3用
			if(SceneManager.GetActiveScene ().name == "Main3"){
				//ハイスコアの保存(匹数)
				if(PlayerPrefs.GetInt("HighScorePlayer3") < totalPlayer){
					//ハイスコア保存
					PlayerPrefs.SetInt("HighScorePlayer3", totalPlayer);
					Debug.Log("HighScorePlayer3:" + PlayerPrefs.GetInt("HighScorePlayer3"));
				}
				//ハイスコアの保存(タイム)
				if(PlayerPrefs.GetFloat("HighScoreTime3") < finishTime){
					//ハイスコア保存
					PlayerPrefs.SetFloat("HighScoreTime3", finishTime);
					Debug.Log("HighScoreTime3:" + PlayerPrefs.GetFloat("HighScoreTime3"));
				}
			}
			//Main4用
			if(SceneManager.GetActiveScene ().name == "Main4"){
				//ハイスコアの保存(匹数)
				if(PlayerPrefs.GetInt("HighScorePlayer4") < totalPlayer){
					//ハイスコア保存
					PlayerPrefs.SetInt("HighScorePlayer4", totalPlayer);
					Debug.Log("HighScorePlayer4:" + PlayerPrefs.GetInt("HighScorePlayer4"));
				}
				//ハイスコアの保存(タイム)
				if(PlayerPrefs.GetFloat("HighScoreTime4") < finishTime){
					//ハイスコア保存
					PlayerPrefs.SetFloat("HighScoreTime4", finishTime);
					Debug.Log("HighScoreTime4:" + PlayerPrefs.GetFloat("HighScoreTime4"));
				}
			}

			pc.goalTiming = false;		//一回だけ処理
		}

		if(player.transform.position.x > bgCreate){
			if(bgCreate < goalBg){
				//ランダムで出現BGを決める
				int aType = Random.Range(0,2);	//挙動確認用仮の値
				//BGを生成する
				GameObject bg = (GameObject)Instantiate(
					bgObject[aType],	//ランダム生成に対応する
	//				new Vector2(transform.position.x, transform.position.y),
					new Vector2(bgCreate_posX, bgCreate_posY),
					transform.rotation
				);
			}else{
				//GOALを生成する
				Debug.Log("GOAL GO !!");
				GameObject bg = (GameObject)Instantiate(
					bgObjectGoal,	//goalオブジェクト
					new Vector2(bgCreate_posX, bgCreate_posY),
					transform.rotation
				);
			}
			bgCreate += 18.0f;		//次の判定用に加算
			bgCreate_posX += 18.0f;	//次の配置用に加算
			bgCreate_posY -= 1.6f;	//次の配置用に加算
		}
	}
}
