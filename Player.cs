using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	GameObject gameController;		//検索したオブジェクト入れる用
	GameObject player;				//検索したオブジェクト入れる用
	public float jumpPower;			//ジャンプ力
	private bool oneTap = false;	//一回だけ処理
	private bool ground = false;	//地面にいるフラグ
	public bool cameraFollowStop;	//カメラ追従フラグ
	public Canvas goalCamvas;		//UI
	public Canvas playCamvas;		//UI
	public Canvas gameOverCamvas;	//UI
	public bool goalTiming;			//ゴールタイミングのフラグ(time保存用)
	public bool goalNow;			//ゴール中のフラグ
	public bool gameOver;			//ゲームオーバーフラグ
	AudioSource audioSource;			//AudioSourceコンポーネント取得用
	public AudioClip audioClipFall;	//FallSE
	public AudioClip audioClipGet;	//GetSE
	public AudioClip audioClipGoal;	//GoalSE
	public AudioClip audioClipJump;	//JumpSE

	void Start () {
		goalNow = false;
		gameOver = false;	//初期化
		player = GameObject.FindWithTag ("Player");					//Playerタグのオブジェクトを探す
		gameController = GameObject.FindWithTag ("GameController");	//GameControllerオブジェクトを探す
		audioSource = gameObject.GetComponent<AudioSource>();		//AudioSourceコンポーネント取得
	}
	
	void Update () {
		if(gameOver == false){
			//rbって仮の変数にRigidbody2Dコンポーネントを入れる
			Rigidbody2D rb = player.GetComponent<Rigidbody2D>();
			//gcって仮の変数にGameControllerのコンポーネントを入れる
			Tap gc = gameController.GetComponent<Tap>();
			//jaump
			if(gc.playerTap){
				if(oneTap == false && ground == true){
					audioSource.clip = audioClipJump;	//SE決定
					audioSource.Play ();				//SE再生
					rb.AddForce (Vector2.up * jumpPower);	//AddForceにて上方向へ力を加える
					rb.AddForce (Vector2.right * 5.0f);//AddForceにて上方向へ力を加える
					Debug.Log("PLAYER TAP !!");
					oneTap = true;
					ground = false;
				}
			}
			//Tapスクリプトの判定を見ている
			if(gc.playerTap == false){
				oneTap = false;
			}
		}
	}

	//他のオブジェクトとのコリジョン判定
	void OnCollisionEnter2D(Collision2D other) {
		//接触時の処理
		ground = true;	//地面フラグon
	}

	//他のオブジェクトとの当たり判定
	void OnTriggerEnter2D(Collider2D other) {
		//アイテム取得時の処理
		if(other.tag == "Item"){
			audioSource.clip = audioClipGet;	//SE決定
			audioSource.Play ();				//SE再生
		}
			//接触時の処理
		if(other.tag == "Goal"){
			cameraFollowStop = true;	//追従停止フラグon
		}
		//ゴール時
		if(other.tag == "GoalUI"){
			audioSource.clip = audioClipGoal;	//SE決定
			audioSource.Play ();				//SE再生
			goalCamvas.enabled = true;	//GoalUI表示
			playCamvas.enabled = false;	//play中UI非表示
			goalTiming = true;			//ゴールタイミングのフラグon
			goalNow = true;				//ゴール中のフラグon
		}
		//落下時
		if(other.tag == "DeadNaraku"){
			audioSource.clip = audioClipFall;	//SE決定
			audioSource.Play ();				//SE再生
			//pcって仮の変数にPlayerのコンポーネントを入れる
			Player pc = player.GetComponent<Player>();

			gameOverCamvas.enabled = true;	//GameOverUI表示
			playCamvas.enabled = false;		//play中UI非表示
			//iTweenで縮小する
			iTween.ScaleTo (gameObject, iTween.Hash ("x",0, "y", 0, "time", 1f));
			//1秒後に呼び出す
			Invoke("kesu", 1.0f);
			gameOver = true;				//ゲームオーバーフラグon
		}
	}

	//時間差で非アクティブ用
	void kesu(){
		gameObject.SetActive (false);	//GameObjectを非アクティブにする
	}

}
