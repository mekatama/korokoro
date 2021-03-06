﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Fueru : MonoBehaviour {
	public GameObject[] playerSubObject;//playerプレハブ。一応、配列で管理
	GameObject playerSub;				//検索したオブジェクト入れる用

	void Start () {
		playerSub = GameObject.FindWithTag ("PlayerSub");			//PlayerSubタグのオブジェクトを探す
	}
	
	//他のオブジェクトとの当たり判定
	void OnTriggerEnter2D(Collider2D other) {
		//ランダムで出現playerを決める
		int pType = Random.Range(0,7);	//0～7のランダム生成 
		//接触時の処理
		if(other.tag == "Player"){
			//playerSubを生成する
			GameObject playerSub = (GameObject)Instantiate(
				playerSubObject[pType],	//ランダム生成にする
				new Vector2(transform.position.x, transform.position.y + 0.5f),
				transform.rotation
			);
			//rbって仮の変数にRigidbody2Dコンポーネントを入れる
			Rigidbody2D rb = playerSub.GetComponent<Rigidbody2D>();
			//生成時にベクトル発生させる
			rb.AddForce (Vector2.up * 50.0f);		//AddForceにて上方向へ力を加える
			rb.AddForce (Vector2.right * 200.0f);	//AddForceにて右方向へ力を加える
			//gcって仮の変数にGameControllerのコンポーネントを入れる
			Destroy(gameObject);		//このGameObjectを［Hierrchy］ビューから削除する
		}
	}
}
