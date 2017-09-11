using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSub : MonoBehaviour {
	GameObject gameController;		//検索したオブジェクト入れる用
//	GameObject player;				//検索したオブジェクト入れる用

	void Start () {
//		player = GameObject.FindWithTag ("Player");					//Playerタグのオブジェクトを探す
		gameController = GameObject.FindWithTag ("GameController");	//GameControllerオブジェクトを探す
	}

	//他のオブジェクトとの当たり判定
	void OnTriggerEnter2D(Collider2D other) {
		//gcって仮の変数にGameControllerのコンポーネントを入れる
		GameController gc = gameController.GetComponent<GameController>();

		//ゴール時
		if(other.tag == "GoalUI"){
			gc.totalPlayer += 1;	//sub_player数の加算
		}
		//落下時
		if(other.tag == "DeadArea"){
//			gc.totalPlayer -= 1;	//player数の減算
			//■ここに縮小処理をいれたい
//			Destroy(gameObject);	//オブジェクトの削除
			//iTweenで縮小する
			iTween.ScaleTo (gameObject, iTween.Hash ("x",0, "y", 0, "time", 1f));
			//0.1秒後に呼び出す
			Invoke("kesu", 1.0f);
		}
	}

	//時間差で非アクティブ用
	void kesu(){
		gameObject.SetActive (false);	//GameObjectを非アクティブにする
	}
}
