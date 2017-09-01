using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public int totalPlayer = 0;			//ここでplayer数を管理していく
	public GameObject player;			//playerを入れる
	private float bgCreate = -6.0f;		//次のBG生成を判定する座標
	private float bgCreate_posX = 18.0f;//次のBG生成する座標
	public GameObject[] bgObject;		//BGプレハブ。一応、配列で管理

	void Start () {
	}
	
	void Update () {
		if(player.transform.position.x > bgCreate){
			//BGを生成する
			GameObject bg = (GameObject)Instantiate(
				bgObject[0],	//ランダム生成に対応する
//				new Vector2(transform.position.x, transform.position.y),
				new Vector2(bgCreate_posX, -3.0f),
				transform.rotation
			);
			bgCreate += 18.0f;		//次の判定用に加算
			bgCreate_posX += 18.0f;	//次の配置用に加算
//			Debug.Log("BG GO !!");
		}
	}
}
