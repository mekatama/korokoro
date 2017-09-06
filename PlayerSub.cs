using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSub : MonoBehaviour {
	GameObject gameController;		//検索したオブジェクト入れる用
	GameObject player;				//検索したオブジェクト入れる用

	void Start () {
		player = GameObject.FindWithTag ("Player");					//Playerタグのオブジェクトを探す
		gameController = GameObject.FindWithTag ("GameController");	//GameControllerオブジェクトを探す
	}

	//他のオブジェクトとの当たり判定
	void OnTriggerEnter2D(Collider2D other) {
		//落下時
		if(other.tag == "DeadArea"){
			//gcって仮の変数にGameControllerのコンポーネントを入れる
			GameController gc = gameController.GetComponent<GameController>();
			gc.totalPlayer -= 1;	//player数の減算
			//■ここに縮小処理をいれたい
			Destroy(gameObject);	//オブジェクトの削除
		}
	}

}
