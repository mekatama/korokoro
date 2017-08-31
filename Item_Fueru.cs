using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Fueru : MonoBehaviour {
	public GameObject[] playerObject;	//playerプレハブ。一応、配列で管理
	GameObject gameController;			//検索したオブジェクト入れる用

	void Start () {
		gameController = GameObject.FindWithTag ("GameController");	//GameControllerオブジェクトを探す
	}
	
	void Update () {
	}

	//他のオブジェクトとの当たり判定
	void OnTriggerEnter2D(Collider2D other) {
		//ランダムで出現playerを決める
		int pType = Random.Range(0,2);	//挙動確認用仮の値 
		//接触時の処理
		if(other.tag == "Player"){
			//playerを生成する
			GameObject player = (GameObject)Instantiate(
				playerObject[pType],	//ランダム生成にする
				new Vector2(transform.position.x, transform.position.y),
				transform.rotation
			);
			//gcって仮の変数にGameControllerのコンポーネントを入れる
			GameController gc = gameController.GetComponent<GameController>();
			gc.totalPlayer += 1;		//player数の加算
			Destroy(gameObject);		//このGameObjectを［Hierrchy］ビューから削除する
		}
	}

}
