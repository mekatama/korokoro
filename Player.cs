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
	public bool goalTiming;			//ゴールタイミングのフラグ

	void Start () {
		player = GameObject.FindWithTag ("Player");					//Playerタグのオブジェクトを探す
		gameController = GameObject.FindWithTag ("GameController");	//GameControllerオブジェクトを探す
	}
	
	void Update () {
		//rbって仮の変数にRigidbody2Dコンポーネントを入れる
		Rigidbody2D rb = player.GetComponent<Rigidbody2D>();
		//gcって仮の変数にGameControllerのコンポーネントを入れる
		Tap gc = gameController.GetComponent<Tap>();
		//jaump
		if(gc.playerTap){
			if(oneTap == false && ground == true){
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

	//他のオブジェクトとのコリジョン判定
	void OnCollisionEnter2D(Collision2D other) {
		//接触時の処理
		ground = true;	//地面フラグon
	}

	//他のオブジェクトとの当たり判定
	void OnTriggerEnter2D(Collider2D other) {
		//接触時の処理
		if(other.tag == "Goal"){
			cameraFollowStop = true;	//追従停止フラグon
		}
		//ゴール時
		if(other.tag == "GoalUI"){
			goalCamvas.enabled = true;	//GoalUI表示
			playCamvas.enabled = false;	//play中UI非表示
			goalTiming = true;			//ゴールタイミングのフラグon
		}
	}
}
