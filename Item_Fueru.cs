using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Fueru : MonoBehaviour {
	public GameObject[] playerObject;	//playerプレハブ。一応、配列で管理
	public GameObject playerHolder;		//playerプレハブをヒエラルキー画面でまとめるため

	void Start () {
	}
	
	void Update () {
	}

	//他のオブジェクトとの当たり判定
	void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "Player"){
			//playerを生成する
			GameObject player = (GameObject)Instantiate(
				playerObject[0],	//■後でランダム生成にする
				new Vector2(transform.position.x, transform.position.y),
				transform.rotation
			);
			//親オブジェクトの設定
			player.transform.parent = playerHolder.transform;
			//gcって仮の変数にGameControllerのコンポーネントを入れる
//			GameController gc = gameController.GetComponent<GameController>();
			//このGameObjectを［Hierrchy］ビューから削除する
			Destroy(gameObject);
		}
	}

}
