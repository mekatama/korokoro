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
	AudioSource audioSource;			//AudioSourceコンポーネント取得用
	public AudioClip audioClipStart;	//StartSE

	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();	//AudioSourceコンポーネント取得
		audioSource.clip = audioClipStart;	//SE決定
		audioSource.Play ();				//SE再生
	}
	
	void Update () {
		//経過時間チェック
		timePlaying += Time.deltaTime;	//経過時間の保存
		//pcって仮の変数にplayerコンポーネントを入れる
		Player pc = player.GetComponent<Player>();

		//ゴール時の処理
		if(pc.goalTiming){
			finishTime = timePlaying;	//ゴール時のタイムを保存
			pc.goalTiming = false;		//一回だけ処理
		}
		//Main0用
		if(SceneManager.GetActiveScene ().name == "Main0"){
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
}
