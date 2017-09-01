using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	GameObject gameController;		//検索したオブジェクト入れる用
	GameObject player;				//検索したオブジェクト入れる用
	public float jumpPower;			//ジャンプ力
	private bool oneTap = false;	//一回だけ処理

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
			if(oneTap == false){
				rb.AddForce (Vector2.up * jumpPower);	//AddForceにて上方向へ力を加える
				rb.AddForce (Vector2.right * 5.0f);//AddForceにて上方向へ力を加える
				Debug.Log("PLAYER TAP !!");
				oneTap = true;
			}
		}

		if(gc.playerTap == false){
			oneTap = false;
		}
		

	}
}
